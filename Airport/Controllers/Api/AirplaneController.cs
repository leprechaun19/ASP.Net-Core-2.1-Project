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
    [Route("api/Airplane")]
    public class AirplaneController : Controller
    {

        private readonly ApplicationDbContext _context;

        public AirplaneController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Airplane
        [HttpGet]
        public IActionResult GetAirplane()
        {
            foreach(Airplane a in _context.Airplanes.ToList()) {
                a.Airline = _context.Airlines.FirstOrDefault(x => x.AirlineID.Equals(a.AirlineID));
            }
            return Json(new { data =  _context.Airplanes.ToList()});
        }


        // POST: api/Airplane
        [HttpPost]
        public async Task<IActionResult> PostAirplane([FromBody] Airplane air)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Airplane airplane = new Airplane();
                airplane.AirlineID = air.AirlineID;
                airplane.AirplaneType = air.AirplaneType;
                airplane.NumPlaces = air.NumPlaces;

                if (air.AirplaneID == Guid.Empty)
                {
                    airplane.AirplaneID = Guid.NewGuid();
                    _context.Airplanes.Add(airplane);

                     await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Add new data success." });
                }
                else
                {
                    airplane.AirplaneID = air.AirplaneID;
                    _context.Update(airplane);

                    int i = await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Edit data success." });
                }
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }

         }

        // DELETE: api/Airplane/....
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAirplane([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var airplane = _context.Airplanes.SingleOrDefault(m => m.AirplaneID == id);
                if (airplane == null)
                {
                    return NotFound();
                }

                _context.Airplanes.Remove(airplane);
                await _context.SaveChangesAsync();

                return Json(new { success = true, message = "Delete success." });
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }


        }

        private Airplane AirplaneExists(Guid id)
        {
            return _context.Airplanes.Where(e => e.AirplaneID == id).SingleOrDefault();
        }
    }
}
