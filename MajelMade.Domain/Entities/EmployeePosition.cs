using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class EmployeePosition
    {
        public int EmployeePositionID { get; set; }
        public required string PositionName { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
