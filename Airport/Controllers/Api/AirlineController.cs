using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data;
using Airport.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Airport.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Airline")]
    public class AirlineController : Controller
    {

        private readonly ApplicationDbContext _context;

        public AirlineController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Airline
        [HttpGet]
        public IActionResult GetAirline()
        {
            return Json(new { data = _context.Airlines.ToList() });
        }


        // POST: api/Airline
        [HttpPost]
        public async Task<IActionResult> PostAirline([FromBody] Airline airline)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {

                if (airline.AirlineID== Guid.Empty)
                {
                    airline.AirlineID= Guid.NewGuid();
                    _context.Airlines.Add(airline);

                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Add new data success." });
                }
                else
                {
                    _context.Update(airline);

                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Edit data success." });
                }
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }

        }

        // DELETE: api/Airline/....
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAirline([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var airline = _context.Airlines.SingleOrDefault(m => m.AirlineID== id);
                if (airline == null)
                {
                    return NotFound();
                }

                _context.Airlines.Remove(airline);
                await _context.SaveChangesAsync();

                return Json(new { success = true, message = "Delete success." });
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }


        }

        private bool AirlineExists(Guid id)
        {
            return _context.Airlines.Any(e => e.AirlineID == id);
        }
    }
}
