using System;
using System.Threading.Tasks;
using MajelMade.BusinessLogic.Interfaces;
using MajelMade.Data.Repositories.Interfaces;

namespace MajelMade.BusinessLogic.Services
{
    public class EquipmentService(IEquipmentRepository _equipmentRepository) : IEquipmentService
    {

        public async Task<bool> CheckEquipmentAvailabilityAsync(int equipmentId)
        {
            var equipment = await _equipmentRepository.GetByIdAsync(equipmentId);
            return equipment != null && equipment.EquipmentStatusID == 1; // 1 = Available
        }

        public async Task LogEquipmentUsageAsync(int equipmentId, int recipeId, DateTime startTime, DateTime endTime)
        {
            await _equipmentRepository.LogUsageAsync(equipmentId, recipeId, startTime, endTime);
        }

        public async Task MarkEquipmentAsBrokenAsync(int equipmentId, string reason)
        {
            await _equipmentRepository.UpdateEquipmentStatusAsync(equipmentId, 3); // 3 = Broken
        }

        public async Task ScheduleMaintenanceAsync(int equipmentId, DateTime nextMaintenanceDate)
        {
            await _equipmentRepository.SetNextMaintenanceDateAsync(equipmentId, nextMaintenanceDate);
        }
    }
}
