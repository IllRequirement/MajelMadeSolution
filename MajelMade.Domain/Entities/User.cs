using System;
using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public required string Username { get; set; }
        public required string PasswordHash { get; set; }
        public required string Email { get; set; }
        public DateTime DateCreated { get; set; }
        public int RoleID { get; set; }

        public required Role Role { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
