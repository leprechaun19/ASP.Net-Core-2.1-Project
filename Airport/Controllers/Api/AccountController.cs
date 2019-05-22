using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Account")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
           SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // POST api/Account
        [HttpPost]
        public async Task<IActionResult> PostLogin([FromBody] Models.AccountViewModels.LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { success = false, message = "Invalid data." });
            }

            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                ApplicationUser user = await _userManager.FindByEmailAsync(model.Email);
                if (user.IsSuperAdmin) {
                    return Json(new { success = true, message = "Super Admin" });
                }
                else
                {
                    return Json(new { success = true, message = "User" });
                }
                
            }
            if (result.IsLockedOut)
            {
                return Json(new { success = false, message = "Your account was lock out." });
            }
            else
            {
                return Json(new { success = false, message = "Invalid login attempt." });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetRegister([FromBody] Models.AccountViewModels.RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email, FullName = model.FullName };

                ///user.IsSuperAdmin = true;
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return Json(new { success = true, message = "OK" });
                }
                else {
                    return Json(new { success = true, message = "Can t create user." });
                }
            }
            else
            {
                return Json(new { success = false, message = "Invalid data." });
            }
        }
    }
}
