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

        public async Task<ModificationType?> GetByIdAsync(object id)
        {
            return await _context.ModificationTypes.FindAsync(id);
        }

        public async Task AddAsync(ModificationType entity)
        {
            await _context.ModificationTypes.AddAsync(entity);
        }

        public void Update(ModificationType entity)
        {
            _context.ModificationTypes.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(ModificationType entity)
        {
            _context.ModificationTypes.Remove(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
