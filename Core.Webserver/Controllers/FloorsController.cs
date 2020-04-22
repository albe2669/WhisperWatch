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
    public class IndexViewModel
    {
        public IList<Floor> Floors { get; set; }
    }

    [Route("api/building/{buildingId:long}/floors")]
    [ApiController]
    public class FloorsController : ControllerBase
    {
        private readonly SchoolContext _context;

        public FloorsController(SchoolContext context)
        {
            _context = context;
        }

        // GET: api/building/{buildingId:long}/floors
        [HttpGet]
        public async Task<ActionResult<List<FloorViewStandard>>> GetFloors([FromRoute] long buildingId)
        {
            return await _context.Floors
                .Where(f => f.BuildingId == buildingId)
                .Select(f => new FloorViewStandard
                {
                    Id = f.Id,
                    BuildingId = f.BuildingId,
                    Level = f.Level,
                    Name = f.Name,
                    Description = f.Description
                }).ToListAsync();
        }

        // GET: api/building/{buildingId:long}/floors/{id:long}
        [HttpGet("{id}")]
        public async Task<ActionResult<FloorViewRooms>> GetFloor(long buildingId, long id)
        {

            FloorViewRooms floor = await _context.Floors
                .Where(f => f.Id == id)
                .Where(f => f.BuildingId == buildingId)
                .Select(f => new FloorViewRooms
                {
                    Id = f.Id,
                    BuildingId = f.BuildingId,
                    Level = f.Level,
                    Name = f.Name,
                    Description = f.Description,
                    Rooms = f.Rooms.Select(r => new RoomViewNoFloor
                    {
                        Id = r.Id,
                        Name = r.Name,
                        Number = r.Number,
                        Area = r.Area
                    }).ToList()
                }).FirstOrDefaultAsync();

            if (floor == null)
            {
                return NotFound();
            }

            return floor;
        }

        /*
        // PUT: api/Floors/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFloor(long id, Floor floor)
        {
            if (id != floor.Id)
            {
                return BadRequest();
            }

            _context.Entry(floor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FloorExists(id))
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

        // POST: api/Floors
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Floor>> PostFloor(Floor floor)
        {
            _context.Floors.Add(floor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFloor", new { id = floor.Id }, floor);
        }

        // DELETE: api/Floors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Floor>> DeleteFloor(long id)
        {
            var floor = await _context.Floors.FindAsync(id);
            if (floor == null)
            {
                return NotFound();
            }

            _context.Floors.Remove(floor);
            await _context.SaveChangesAsync();

            return floor;
        }

        private bool FloorExists(long id)
        {
            return _context.Floors.Any(e => e.Id == id);
        }*/
    }
}
