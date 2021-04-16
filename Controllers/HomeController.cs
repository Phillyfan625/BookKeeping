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

        private BookKeeperListModel blmList = new BookKeeperListModel();
        private BookKeeper bList = new BookKeeper();
        private Client cList = new Client();

        public HomeController(BookKeepingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            blmList.Bookkeepers = _context.BookKeeper.ToList();
            return View(blmList);
        }

        public ViewResult BookkeeperDetails(int id)
        {
            var details = (from b in _context.BookKeeper
                           where b.BookKeeperID == id
                           select b).FirstOrDefault();
            bList.Clients = (from c in _context.Client
                             where c.BookKeeperID == id
                             select c).ToList();
            cList.Reviews = (from r in _context.Reviews
                             where r.BookKeeperID == id
                             select r).ToList();
            return View(details);
        } 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
