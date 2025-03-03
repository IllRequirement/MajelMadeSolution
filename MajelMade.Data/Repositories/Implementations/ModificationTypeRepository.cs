using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MajelMade.Data.Contexts;
using MajelMade.Data.Repositories.Interfaces;
using MajelMade.Domain.Entities;

namespace MajelMade.Data.Repositories.Implementations
{
    public class ModificationTypeRepository(MajelMadeDbContext _context) : IModificationTypeRepository
    {
        public async Task<IEnumerable<ModificationType>> GetAllAsync()
        {
            return await _context.ModificationTypes.ToListAsync();
        }
    }
}
