using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookKeeping.Models;

namespace BookKeeping.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookKeepingContext _context;

        private BookKeeper bList = new BookKeeper();
        private Reviews rList = new Reviews();

        public HomeController(BookKeepingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ViewResult BookkeeperDetails(int id)
        {
            var details = (from b in _context.BookKeeper
                           where b.BookKeeperID == id
                           select b).FirstOrDefault();
             bList.Reviews = (from r in _context.Reviews
                             where r.BookKeeperID == id
                             select r).ToList();
            //rList.Clients = (from c in _context.Client
            //                 where c.BookKeeperID == id
            //                 select c).ToList();

            return View(details);
        } 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
