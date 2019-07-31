using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data;
using Airport.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airport.Controllers
{
    public class AirportController : Controller
    {
        private readonly ApplicationDbContext _DBcontext;

        public AirportController(ApplicationDbContext context)
        {
            _DBcontext = context;
        }

        public IActionResult Index()
        {
            IList<Airportt> airports = _DBcontext.Airportts.ToList();
            return View(airports);
        }

        public IActionResult AddEdit(Guid id)
        {
            if (id == Guid.Empty)
            {
                Airportt airport = new Airportt();
                return View(airport);
            }
            else
            {
                return View(_DBcontext.Airportts.Where(x => x.AirportID.Equals(id)).FirstOrDefault());
            }

        }
    }
}
