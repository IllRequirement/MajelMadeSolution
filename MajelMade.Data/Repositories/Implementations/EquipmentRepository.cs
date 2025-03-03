using System;
using System.Threading.Tasks;
using MajelMade.Data.Contexts;
using MajelMade.Data.Repositories.Interfaces;
using MajelMade.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MajelMade.Data.Repositories.Implementations
{
    public class EquipmentRepository(MajelMadeDbContext _context)
    {

        public async Task<Equipment?> GetByIdAsync(int equipmentId)
        {
            return await _context.Equipment
                .Include(e => e.EquipmentLogs)
                .FirstOrDefaultAsync(e => e.EquipmentID == equipmentId);
        }

        public async Task UpdateEquipmentStatusAsync(int equipmentId, int newStatusId)
        {
            var equipment = await _context.Equipment.FindAsync(equipmentId);
            if (equipment != null)
            {
                equipment.EquipmentStatusID = newStatusId;
                await _context.SaveChangesAsync();
            }
        }

        public async Task SetNextMaintenanceDateAsync(int equipmentId, DateTime nextMaintenanceDate)
        {
            var equipment = await _context.Equipment.FindAsync(equipmentId);
            if (equipment != null)
            {
                equipment.NextMaintenanceDue = nextMaintenanceDate;
                await _context.SaveChangesAsync();
            }
        }

        public async Task LogUsageAsync(int equipmentId, int recipeId, DateTime startTime, DateTime endTime)
        {
            var equipment = await _context.Equipment.FindAsync(equipmentId);
            var logType = await _context.EquipmentLogTypes.FindAsync(2); // 2 = Usage

            if (equipment == null || logType == null)
            {
                throw new InvalidOperationException("Invalid equipment or log type.");
            }

            var log = new EquipmentLog
            {
                EquipmentID = equipmentId,
                Equipment = equipment,  // ✅ Required member
                EquipmentLogTypeID = 2,
                EquipmentLogType = logType, // ✅ Required member
                Duration = (decimal)(endTime - startTime).TotalMinutes,
                Cost = 0,
                Notes = $"Used in Recipe ID: {recipeId}"
            };

            _context.EquipmentLogs.Add(log);
            await _context.SaveChangesAsync();
        }
    }
}
