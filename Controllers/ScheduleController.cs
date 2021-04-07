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

        private BookKeeperListModel list;

        public ScheduleController(BookKeepingContext context)
        {
            _context = context;
        }

        public IActionResult BookkeeperList()
        {
            IList<BookKeeper> Bookkeepers = _context.BookKeeper.ToList();
            return View(Bookkeepers);
        }

        public IActionResult BookkeeperDetails()
        { 
            return View(); 
        }

        //public void Get()
        //{
        //    list.Bookkeepers = _context.Bookkeepers.ToList();
        //}


        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var Bookkeepers = _context.Bookkeepers.ToList();
        //    return Ok(Bookkeepers);
        //}
    }
}
