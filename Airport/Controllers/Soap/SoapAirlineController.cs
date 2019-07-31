using Airport.Data;
using Airport.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Controllers.Soap
{
    [Produces("application/xml")]
    [Route("soap/Airline")]
    public class SoapAirlineController : Controller
    {

        private readonly ApplicationDbContext _context;

        public SoapAirlineController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Airline
        [HttpGet]
        public IEnumerable<Airline> GetAirline()
        {
            return _context.Airlines.ToList();
        }


        // POST: Airline
        [HttpPost]
        public async Task<IActionResult> PostAirline([FromBody] Airline airline)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {

                if (airline.AirlineID == Guid.Empty)
                {
                    airline.AirlineID = Guid.NewGuid();
                    _context.Airlines.Add(airline);

                    await _context.SaveChangesAsync();

                    return Ok();
                }
                else
                {
                    _context.Update(airline);

                    await _context.SaveChangesAsync();

                    return Ok();
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
