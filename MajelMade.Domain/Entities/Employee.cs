using System;

namespace MajelMade.Domain.Entities
{
    public class Employee(int employeeID, int userID, string employeeName, int employeePositionID, string codeID, DateTime? startDate, decimal hourlyRate)
    {
        public int EmployeeID { get; set; } = employeeID;
        public int UserID { get; set; } = userID;
        public string EmployeeName { get; set; } = employeeName;
        public int EmployeePositionID { get; set; } = employeePositionID;
        public string CodeID { get; set; } = codeID;
        public DateTime? StartDate { get; set; } = startDate;
        public decimal HourlyRate { get; set; } = hourlyRate;

        public required User User { get; set; }
        public required EmployeePosition EmployeePosition { get; set; }
    }
}
