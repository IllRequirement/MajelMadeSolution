using System.Collections.Generic;
using System.Threading.Tasks;
using MajelMade.Domain.Entities;

namespace MajelMade.Data.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee?> GetEmployeeByIdAsync(int employeeId);
        Task AddEmployeeAsync(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        Task SaveAsync();
    }
}
