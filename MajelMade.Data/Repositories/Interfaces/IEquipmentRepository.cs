using System;
using System.Threading.Tasks;
using MajelMade.Domain.Entities;

namespace MajelMade.Data.Repositories.Interfaces
{
    public interface IEquipmentRepository
    {
        Task<Equipment?> GetByIdAsync(int equipmentId);
        Task UpdateEquipmentStatusAsync(int equipmentId, int newStatusId);
        Task SetNextMaintenanceDateAsync(int equipmentId, DateTime nextMaintenanceDate);
        Task LogUsageAsync(int equipmentId, int recipeId, DateTime startTime, DateTime endTime);
    }
}
