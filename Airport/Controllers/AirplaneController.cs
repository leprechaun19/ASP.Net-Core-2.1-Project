using System;
using System.Collections.Generic;
using System.Linq;
using Airport.Data;
using Airport.Models;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    public class AirplaneController : Controller
    {
        private readonly ApplicationDbContext _DBcontext;

        public AirplaneController(ApplicationDbContext context)
        {
            _DBcontext = context;
        }

        public IActionResult Index()
        {
            IList<Airplane> airplanes = _DBcontext.Airplanes.ToList();
            return View(airplanes);
        }

        public IActionResult Add(Guid id)
        {
            if(id != null)
            {
                ViewBag.Airlines = _DBcontext.Airlines.ToList();
                return View(_DBcontext.Airlines.Where(x => x.AirlineID.Equals(id)).FirstOrDefault());
            }
            else
            {
                Airplane airplane = new Airplane();
                ViewBag.Airlines = _DBcontext.Airlines.ToList();
                return View(airplane);
            }            
        }
    }
}
