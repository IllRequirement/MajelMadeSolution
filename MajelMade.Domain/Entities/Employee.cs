using System;

namespace MajelMade.Domain.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public int UserID { get; set; }
        public required string EmployeeName { get; set; }
        public int EmployeePositionID { get; set; }
        public required string CodeID { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal HourlyRate { get; set; } 

        public required User User { get; set; }
        public required EmployeePosition EmployeePosition { get; set; }
    }
}
