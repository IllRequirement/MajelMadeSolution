namespace MajelMade.Domain.Entities;

public class Role(int roleID, string roleName)
{
    public int RoleID { get; init; } = roleID;
    public string RoleName { get; init; } = roleName;

    public ICollection<User> Users { get; init; } = new List<User>();
}
