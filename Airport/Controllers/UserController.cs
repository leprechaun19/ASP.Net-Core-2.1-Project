using Airport.Data;
using Airport.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _DBcontext;

        public UserController(ApplicationDbContext context)
        {
            _DBcontext = context;
        }

        public IActionResult Index()
        {
            IList<User> users = _DBcontext.User.ToList();
            return View(users);
        }

        public IActionResult AddEdit(Guid id)
        {
            if (id == Guid.Empty)
            {
                User user = new User();
                return View(user);
            }
            else
            {
                return View(_DBcontext.User.Where(x => x.UserId.Equals(id)).FirstOrDefault());
            }

        }

    }
}
