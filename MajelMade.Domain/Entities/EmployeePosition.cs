namespace MajelMade.Domain.Entities
{
    public class EmployeePosition(int employeePositionID, string positionName)
    {
        public int EmployeePositionID { get; set; } = employeePositionID;
        public string PositionName { get; set; } = positionName;

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
