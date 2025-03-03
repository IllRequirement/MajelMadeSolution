using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MajelMade.Data.Contexts;
using MajelMade.Domain.Entities;
using MajelMade.Data.Repositories.Interfaces;

namespace MajelMade.Data.Repositories.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly MajelMadeDbContext _context;

        public EmployeeRepository(MajelMadeDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employees
                                 .Include(e => e.User)
                                 .ThenInclude(u => u.Role)
                                 .ToListAsync();
        }

        public async Task<Employee?> GetEmployeeByIdAsync(int employeeId)
        {
            return await _context.Employees
                                 .Include(e => e.User)
                                 .ThenInclude(u => u.Role)
                                 .FirstOrDefaultAsync(e => e.EmployeeID == employeeId);
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
