using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data;
using Airport.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airport.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/TimeTable")]
    public class TimeTableController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TimeTableController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TimeTable
        [HttpGet]
        public IActionResult GetTimeTables()
        {
            return Json(new { data = _context.TimeTables.ToList() });
        }


        // POST: api/TimeTable
        [HttpPost]
        public async Task<IActionResult> PostAirline([FromBody] TimeTable timeTable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {

                if (timeTable.TimeTableID == Guid.Empty)
                {
                    timeTable.TimeTableID = Guid.NewGuid();
                    _context.TimeTables.Add(timeTable);

                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Add new data success." });
                }
                else
                {
                    _context.Update(timeTable);

                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Edit data success." });
                }
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }

        }

        // DELETE: api/TimeTable/....
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTimeTable([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var timeTable = _context.TimeTables.SingleOrDefault(m => m.TimeTableID == id);
                if (timeTable == null)
                {
                    return NotFound();
                }

                _context.TimeTables.Remove(timeTable);
                await _context.SaveChangesAsync();

                return Json(new { success = true, message = "Delete success." });
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }


        }

        private bool TimeTableExists(Guid id)
        {
            return _context.TimeTables.Any(e => e.TimeTableID == id);
        }
    }
}
