using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MajelMade.Data.Contexts;

public class MajelMadeDbContextFactory : IDesignTimeDbContextFactory<MajelMadeDbContext>
{
    public MajelMadeDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MajelMadeDbContext>();
        optionsBuilder.UseSqlServer("Server=host.docker.internal,1433;Database=MajelMade;User Id={SQL_USER};Password={SQL_PASSWORD};Encrypt=True;TrustServerCertificate=True;");

        return new MajelMadeDbContext(optionsBuilder.Options);
    }
}