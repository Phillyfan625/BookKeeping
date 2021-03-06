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

        private BookKeeperListModel list = new BookKeeperListModel();

        public ScheduleController(BookKeepingContext context)
        {
            _context = context;
        }

        public IActionResult BookkeeperList()
        {
            list.Bookkeepers = _context.BookKeeper.ToList();
            return View(list);
        }

        public IActionResult BookkeeperDetails()
        {
           
            return View(); 
        }
    }
}
