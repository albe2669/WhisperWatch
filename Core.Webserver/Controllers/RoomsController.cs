using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Classes.Webserver.Data.SchoolContext;
using Classes.Webserver.Models;

namespace Core.Webserver.Controllers
{
    public class IndexRoomModel
    {
        public List<AlteredRoomModel> Rooms { get; set; }

        public IndexRoomModel()
        {
            Rooms = new List<AlteredRoomModel>();
        }
    }

    public class AlteredRoomModel
    {
        public Room room { get; set; }
        public RoomMessage roomMessages { get; set; }
    }

    [Route("api/building/{buildingId:long}/floor/{floorId:long}/room")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly SchoolContext _context;

        public RoomsController(SchoolContext context)
        {
            _context = context;
        }

        // GET: api/Rooms
        [HttpGet]
        public async Task<ActionResult<List<Room>>> GetRooms([FromRoute] long buildingId, [FromRoute] long floorId)
        {
            var viewModel = new IndexRoomModel();

            var rooms = await _context.Rooms
                .Where(f => f.FloorId == floorId)
                .Include(r => r.RoomMessages)
                .ThenInclude(t => t.Devices)
                .ToListAsync();
            /*foreach (Room room in rooms)
            {
                
                if (room == null)
                {
                    continue;
                }

                AlteredRoomModel model = new AlteredRoomModel();
                model.room = room;
                model.roomMessages = await _context.RoomMessages
                    .Where(x => x.RoomId == room.Id)
                    .OrderBy(x => x.LastUpdated)
                    .Include(s => s.Devices)
                    .AsNoTracking()
                    .FirstOrDefaultAsync();

                if (model == null)
                {
                    continue;
                }

                viewModel.Rooms.Add(model);
            }*/

            return rooms;
        }

        // GET: api/Rooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> GetRoom(long id)
        {
            var room = await _context.Rooms.FindAsync(id);

            if (room == null)
            {
                return NotFound();
            }

            return room;
        }

        /*
        // PUT: api/Rooms/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoom(long id, Room room)
        {
            if (id != room.Id)
            {
                return BadRequest();
            }

            _context.Entry(room).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Rooms
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Room>> PostRoom(Room room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoom", new { id = room.Id }, room);
        }

        // DELETE: api/Rooms/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Room>> DeleteRoom(long id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }

            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

            return room;
        }

        private bool RoomExists(long id)
        {
            return _context.Rooms.Any(e => e.Id == id);
        }*/
    }
}
