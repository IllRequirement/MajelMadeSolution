using System.Collections.Generic;
using System.Threading.Tasks;
using MajelMade.Domain.Entities;

namespace MajelMade.Data.Repositories.Interfaces
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> GetAllAsync();
        Task<Room?> GetByIdAsync(int roomId);
        Task AddAsync(Room room);
        void Update(Room room);
        void Delete(Room room);
        Task SaveAsync();
    }
}
