using System.Collections.Generic;
using System.Threading.Tasks;
using MajelMade.BusinessLogic.Interfaces;
using MajelMade.Data.Repositories.Interfaces;
using MajelMade.Domain.Entities;

namespace MajelMade.BusinessLogic.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<IEnumerable<Room>> GetAllRoomsAsync()
        {
            return await _roomRepository.GetAllAsync();
        }

        public async Task<Room?> GetRoomByIdAsync(int roomId)
        {
            return await _roomRepository.GetByIdAsync(roomId);
        }

        public async Task<Room> AddRoomAsync(Room room)
        {
            await _roomRepository.AddAsync(room);
            await _roomRepository.SaveAsync();
            return room;
        }

        public async Task UpdateRoomAsync(Room room)
        {
            _roomRepository.Update(room);
            await _roomRepository.SaveAsync();
        }

        public async Task DeleteRoomAsync(int roomId)
        {
            var room = await _roomRepository.GetByIdAsync(roomId);
            if (room != null)
            {
                _roomRepository.Delete(room);
                await _roomRepository.SaveAsync();
            }
        }
    }
}
