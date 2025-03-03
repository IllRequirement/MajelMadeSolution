using System.Collections.Generic;
using System.Threading.Tasks;
using MajelMade.Domain.Entities;

namespace MajelMade.Data.Repositories.Interfaces
{
    public interface IModificationTypeRepository : IGenericRepository<ModificationType>
    {
        // Add any additional methods specific to ModificationType if needed.
        new Task<IEnumerable<ModificationType>> GetAllAsync();
    }
}
