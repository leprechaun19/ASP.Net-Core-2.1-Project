using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data;
using Airport.Models;
using Airport.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/UploadFile")]
    [Authorize]
    public class UploadFileController : Controller
    {
        private readonly IHostingEnvironment _env;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public UploadFileController(UserManager<ApplicationUser> userManager,
            ApplicationDbContext context, IHostingEnvironment env)
        {
            _env = env;
            _userManager = userManager;
            _context = context;
        }

        [HttpPost]
        [RequestSizeLimit(5000000)]
        public async Task<IActionResult> PostUploadFile(List<IFormFile> files)
        {
            try
            {
                UplodeFile uplodeFile = new UplodeFile();
                var fileName = await uplodeFile.UploadFile(files, _env);

                ApplicationUser appUser = await _userManager.GetUserAsync(User);
                appUser.ProfilePictureUrl = "/uploads/" + fileName;
                _context.Update(appUser);
                _context.SaveChanges();
                return Ok(fileName);
            }
            catch (Exception ex)
            {

                return StatusCode(500, new
                {
                    message = ex.Message
                });
            }


        }
    }
}
