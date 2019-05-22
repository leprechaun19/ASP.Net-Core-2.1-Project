using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data;
using Airport.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public IActionResult Edit(Guid id)
        {
            return View(_DBcontext.Airlines.Where(x => x.AirlineID.Equals(id)).FirstOrDefault());
        }

        public IActionResult Add()
        {
            Models.AirplaneViewModels.AddAirplaneViewModel model = new Models.AirplaneViewModels.AddAirplaneViewModel();
            ViewBag.Airlines = _DBcontext.Airlines.ToList();
            model.AirplaneID = new Guid();
            model.AirlineID = new Guid();
            return View(model);
        }
    }
}
