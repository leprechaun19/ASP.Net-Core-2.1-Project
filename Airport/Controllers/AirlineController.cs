using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data;
using Airport.Models;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    public class AirlineController : Controller
    {
        private readonly ApplicationDbContext _DBcontext;

        public AirlineController(ApplicationDbContext context)
        {
            _DBcontext = context;
        }

        public IActionResult Index()
        {
            IList<Airline> airlines = _DBcontext.Airlines.ToList();
            return View(airlines);
        }

        public IActionResult AddEdit(Guid id)
        {
            if (id == Guid.Empty)
            {
                Airline airline = new Airline();
                return View(airline);
            }
            else
            {
                return View(_DBcontext.Airlines.Where(x => x.AirlineID.Equals(id)).FirstOrDefault());
            }

        }
    }
}
