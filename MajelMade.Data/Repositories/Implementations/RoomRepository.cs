using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MajelMade.Data.Contexts;
using MajelMade.Domain.Entities;
using MajelMade.Data.Repositories.Interfaces;

namespace MajelMade.Data.Repositories.Implementations
{
    public class RoomRepository : IRoomRepository
    {
        private readonly MajelMadeDbContext _context;

        public RoomRepository(MajelMadeDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Room>> GetAllAsync()
        {
            return await _context.Rooms
                .Include(r => r.ScannableLabel)  // if you need to include the related label
                .Include(r => r.StorageLocations) // if you want to load storage locations
                .ToListAsync();
        }

        public async Task<Room?> GetByIdAsync(int roomId)
        {
            return await _context.Rooms
                .Include(r => r.ScannableLabel)
                .Include(r => r.StorageLocations)
                .FirstOrDefaultAsync(r => r.RoomID == roomId);
        }

        public async Task AddAsync(Room room)
        {
            await _context.Rooms.AddAsync(room);
        }

        public void Update(Room room)
        {
            _context.Rooms.Update(room);
        }

        public void Delete(Room room)
        {
            _context.Rooms.Remove(room);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
