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
    public class TimeTableController : Controller
    {
        private readonly ApplicationDbContext _DBcontext;

        public TimeTableController(ApplicationDbContext context)
        {
            _DBcontext = context;
        }

        public IActionResult Index()
        {
            IList<TimeTable> timetables = _DBcontext.TimeTables.ToList();
            return View(timetables);
        }

        public IActionResult AddEdit(Guid id)
        {
            if (id == Guid.Empty)
            {
                TimeTable timeTable = new TimeTable();
                return View(timeTable);
            }
            else
            {
                return View(_DBcontext.TimeTables.Where(x => x.TimeTableID.Equals(id)).FirstOrDefault());
            }

        }
    }
}
