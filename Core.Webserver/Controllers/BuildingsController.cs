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
    [Route("api/buildings")]
    [ApiController]
    public class BuildingsController : ControllerBase
    {
        private readonly SchoolContext _context;

        public BuildingsController(SchoolContext context)
        {
            _context = context;
        }

        // GET: api/Buildings
        [HttpGet]
        public async Task<ActionResult<List<BuildingViewStandardWithFloors>>> GetBuildings()
        {
            return await _context.Buildings
                .Select(b => new BuildingViewStandardWithFloors
                {
                    Id = b.Id,
                    Name = b.Name,
                    Address = b.Address,
                    Floors = b.Floors.Select(f => new FloorViewNoBuilding
                    {
                        Id = f.Id,
                        Description = f.Description,
                        Name = f.Name,
                        Level = f.Level
                    }).ToList()
                })
                .ToListAsync();
        }

        // GET: api/Buildings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BuildingViewStandardWithFloors>> GetBuilding(long id)
        {
            BuildingViewStandardWithFloors building = await _context.Buildings
                .Where(b => b.Id == id)
                .Select(b => new BuildingViewStandardWithFloors
                {
                    Id = b.Id,
                    Name = b.Name,
                    Address = b.Address,
                    Floors = b.Floors.Select(f => new FloorViewNoBuilding
                    {
                        Id = f.Id,
                        Description = f.Description,
                        Name = f.Name,
                        Level = f.Level
                    }).ToList()
                })
                .FirstOrDefaultAsync();

            if (building == null)
            {
                return NotFound();
            }

            return building;
        }

        /*
        // PUT: api/Buildings/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBuilding(long id, Building building)
        {
            if (id != building.Id)
            {
                return BadRequest();
            }

            _context.Entry(building).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuildingExists(id))
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

        // POST: api/Buildings
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Building>> PostBuilding(Building building)
        {
            _context.Buildings.Add(building);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBuilding", new { id = building.Id }, building);
        }

        // DELETE: api/Buildings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Building>> DeleteBuilding(long id)
        {
            var building = await _context.Buildings.FindAsync(id);
            if (building == null)
            {
                return NotFound();
            }

            _context.Buildings.Remove(building);
            await _context.SaveChangesAsync();

            return building;
        }

        private bool BuildingExists(long id)
        {
            return _context.Buildings.Any(e => e.Id == id);
        }*/
    }
}
