using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MajelMade.BusinessLogic.Interfaces;
using MajelMade.Domain.Entities;
using System.Collections.Generic;

namespace MajelMade.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        // GET: api/Rooms
        [HttpGet]
        public async Task<IActionResult> GetRooms()
        {
            IEnumerable<Room> rooms = await _roomService.GetAllRoomsAsync();
            return Ok(rooms);
        }

        // GET: api/Rooms/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoom(int id)
        {
            Room? room = await _roomService.GetRoomByIdAsync(id);
            if (room == null)
                return NotFound();

            return Ok(room);
        }

        // POST: api/Rooms
        [HttpPost]
        public async Task<IActionResult> CreateRoom([FromBody] Room room)
        {
            if (room == null)
                return BadRequest();

            var createdRoom = await _roomService.AddRoomAsync(room);
            return CreatedAtAction(nameof(GetRoom), new { id = createdRoom.RoomID }, createdRoom);
        }

        // PUT: api/Rooms/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRoom(int id, [FromBody] Room room)
        {
            if (id != room.RoomID)
                return BadRequest("ID mismatch");

            await _roomService.UpdateRoomAsync(room);
            return NoContent();
        }

        // DELETE: api/Rooms/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            await _roomService.DeleteRoomAsync(id);
            return NoContent();
        }
    }
}
