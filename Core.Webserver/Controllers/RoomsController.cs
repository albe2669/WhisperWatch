using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Classes.Webserver.Data.SchoolContext;
using Classes.Webserver.Models;
using Classes.Webserver.Data.ViewModel;

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
        public RoomViewStandard room { get; set; }
        public List<DeviceViewStandard> devices { get; set; }
    }

    [Route("api/building/{buildingId:long}/floor/{floorId:long}/rooms")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly SchoolContext _context;

        public RoomsController(SchoolContext context)
        {
            _context = context;
        }

        // GET: api/building/{buildingId:long}/floor/{floorId:long}/rooms
        [HttpGet]
        public async Task<ActionResult<IndexRoomModel>> GetRooms([FromRoute] long buildingId, [FromRoute] long floorId)
        {
            var viewModel = new IndexRoomModel();

            var rooms = await _context.Rooms
                .Where(f => f.FloorId == floorId)
                .Select(r => new RoomViewStandard { 
                    Id = r.Id,
                    FloorId = r.FloorId,
                    Number = r.Number,
                    Name = r.Name,
                    Area = r.Area
                })
                .ToListAsync();

            foreach (RoomViewStandard room in rooms)
            {
              
                if (room == null)
                {
                    continue;
                }

                AlteredRoomModel model = new AlteredRoomModel();
                RoomMessage message = await _context.RoomMessages
                    .Where(x => x.RoomId == room.Id)
                    .Where(x => x.LastUpdated > DateTime.Now.AddMinutes(-10))
                    .AsNoTracking()
                    .FirstOrDefaultAsync();

                if (message == null)
                {
                    continue;
                }

                model.room = room;
                model.devices = await _context.Devices
                    .Where(d => d.RoomMessageId == message.Id)
                    .Select(p => new DeviceViewStandard
                    {
                        Id = p.Id,
                        MacAddress = p.MacAdress,
                        SignalStrength = p.SignalStrength
                    })
                    .ToListAsync();

                if (model == null)
                {
                    continue;
                }

                viewModel.Rooms.Add(model);
            }

            return viewModel;
        }

        // GET: api/building/{buildingId:long}/floor/{floorId:long}/rooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlteredRoomModel>> GetRoom(long id)
        {
            var room = await _context.Rooms
                .Select(r => new RoomViewStandard {
                    Id = r.Id,
                    FloorId = r.FloorId,
                    Number = r.Number,
                    Name = r.Name,
                    Area = r.Area
                })
                .Where(r => r.Id == id)
                .FirstOrDefaultAsync();

            if (room == null)
            {
                return NotFound();
            }

            AlteredRoomModel model = new AlteredRoomModel();
            RoomMessage message = await _context.RoomMessages
                .Where(x => x.RoomId == room.Id)
                .Where(x => x.LastUpdated > DateTime.Now.AddMinutes(-10))
                .AsNoTracking()
                .FirstOrDefaultAsync();


            model.room = room;

            if (message == null)
            {
                return model;
            }

            model.devices = await _context.Devices
                .Where(d => d.RoomMessageId == message.Id)
                .Select(p => new DeviceViewStandard
                {
                    Id = p.Id,
                    MacAddress = p.MacAdress,
                    SignalStrength = p.SignalStrength
                })
                .ToListAsync();
            
            return model;
        }
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
