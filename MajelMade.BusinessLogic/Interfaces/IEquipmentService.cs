using System;
using System.Threading.Tasks;

namespace MajelMade.BusinessLogic.Interfaces
{
    public interface IEquipmentService
    {
        Task<bool> CheckEquipmentAvailabilityAsync(int equipmentId);
        Task LogEquipmentUsageAsync(int equipmentId, int recipeId, DateTime startTime, DateTime endTime);
        Task MarkEquipmentAsBrokenAsync(int equipmentId, string reason);
        Task ScheduleMaintenanceAsync(int equipmentId, DateTime nextMaintenanceDate);
    }
}
