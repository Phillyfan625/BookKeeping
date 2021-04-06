using BookKeeping.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookKeeping.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly BookKeepingContext _context;

        public ScheduleController(BookKeepingContext context)
        {
            _context = context;
        }

        public IActionResult BookkeeperList()
        {
            return View();
        }

        public IActionResult BookkeeperDetails()
        {
            return View(); 
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Bookkeepers = _context.Bookkeepers.ToList();
            return Ok(Bookkeepers);
        }
    }
}
