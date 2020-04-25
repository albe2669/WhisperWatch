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
    [Route("api/buildings/{buildingId:long}/floors/{floorId:long}/rooms")]
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
        public async Task<ActionResult<List<RoomViewWithDevices>>> GetRooms([FromRoute] long buildingId, [FromRoute] long floorId)
        {
            List<RoomViewWithDevices> rooms = await _context.Rooms
                .Where(f => f.FloorId == floorId)
                .Select(r => new RoomViewWithDevices { 
                    Id = r.Id,
                    FloorId = r.FloorId,
                    Number = r.Number,
                    Name = r.Name,
                    Area = r.Area
                })
                .ToListAsync();

            foreach (RoomViewWithDevices room in rooms.Reverse<RoomViewWithDevices>())
            {
                List<DeviceViewNoRoom> devices = new List<DeviceViewNoRoom>();
                var messages = await _context.RoomMessages
                    .Where(x => x.RoomId == room.Id)
                    .Where(x => x.LastUpdated > DateTime.Now.AddMinutes(-5))
                    .Select(m => new
                    {
                        Id = m.Id,
                        Devices = m.Devices.Select(d => new DeviceViewNoRoom
                        {
                            MacAddress = d.MacAdress,
                            SignalStrength = d.SignalStrength
                        }).ToList()
                    })
                    .AsNoTracking()
                    .ToListAsync();

                if (messages == null || messages.Count == 0)
                {
                    rooms.Remove(room);
                    continue;
                }

                foreach (var message in messages)
                {
                    devices.AddRange(message.Devices);
                }

                devices.GroupBy(d => d.MacAddress);

                List<DeviceViewNoRoom> deviceGroups =
                    (from device in devices
                     group device by device.MacAddress into deviceGroup
                     select new DeviceViewNoRoom
                     {
                         MacAddress = deviceGroup.Key,
                         SignalStrength = deviceGroup.Average(x => x.SignalStrength)
                     }).ToList();
                room.Devices = deviceGroups;

            }

            return rooms;
        }

        // GET: api/building/{buildingId:long}/floor/{floorId:long}/rooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoomViewWithDevices>> GetRoom(long floorId, long id)
        {
            var room = await _context.Rooms
                .Select(r => new RoomViewWithDevices
                {
                    Id = r.Id,
                    FloorId = r.FloorId,
                    Number = r.Number,
                    Name = r.Name,
                    Area = r.Area
                })
                .Where(r => r.Id == id)
                .Where(r => r.FloorId == floorId)
                .FirstOrDefaultAsync();

            if (room == null)
            {
                return NotFound();
            }

            RoomMessage message = await _context.RoomMessages
                .Where(x => x.RoomId == room.Id)
                .Where(x => x.LastUpdated > DateTime.Now.AddMinutes(-10))
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (message == null)
            {
                return room;
            }

            room.Devices = await _context.Devices
                .Where(d => d.RoomMessageId == message.Id)
                .Select(p => new DeviceViewNoRoom
                {
                    MacAddress = p.MacAdress,
                    SignalStrength = p.SignalStrength
                })
                .ToListAsync();
            
            return room;
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
