using Airport.Data;
using Airport.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/User
        [HttpGet]
        public IActionResult GetUser()
        {
            return Json(new { data = _context.User.ToList() });
        }

        // POST: api/User/ChangePersonalProfile
        [HttpPost("ChangePersonalProfile")]
        public async Task<IActionResult> ChangePersonalProfile([FromBody] ApplicationUser applicationUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                ApplicationUser appUser = _context.ApplicationUsers.Where(x => x.Id.Equals(applicationUser.Id)).FirstOrDefault();
                appUser.FullName = applicationUser.FullName;
                _context.Update(appUser);

                await _context.SaveChangesAsync();

                return Json(new { success = true, message = "Edit data success.", appUser });
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }


        }

        // POST: api/User
        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {

                if (user.UserId == Guid.Empty)
                {
                    user.UserId = Guid.NewGuid();
                    _context.User.Add(user);

                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Add new data success." });
                }
                else
                {
                    _context.Update(user);

                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Edit data success." });
                }
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }

        }

        // DELETE: api/User/....
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var user =  _context.User.SingleOrDefault(m => m.UserId == id);
                if (user == null)
                {
                    return NotFound();
                }

                _context.User.Remove(user);
                await _context.SaveChangesAsync();

                return Json(new { success = true, message = "Delete success." });
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }


        }

        private bool UserExists(Guid id)
        {
            return _context.User.Any(e => e.UserId == id);
        }
    }
}
