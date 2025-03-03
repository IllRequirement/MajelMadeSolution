using System.Collections.Generic;
using System.Threading.Tasks;
using MajelMade.Domain.Entities;

namespace MajelMade.BusinessLogic.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee?> GetEmployeeByIdAsync(int employeeId);
        // Optionally, add methods like AddEmployeeAsync, UpdateEmployeeAsync, DeleteEmployeeAsync, etc.
    }
}
