namespace MajelMade.Domain.Entities;

public class User(int userID, string username, string passwordHash, string email, DateTime dateCreated, int roleID, Role role)
{
    public int UserID { get; init; } = userID;
    public string Username { get; init; } = username;
    public string PasswordHash { get; init; } = passwordHash;
    public string Email { get; init; } = email;
    public DateTime DateCreated { get; init; } = dateCreated;
    public int RoleID { get; init; } = roleID;

    public Role Role { get; init; } = role;
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
