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
        private BookKeeperViewModel details = new BookKeeperViewModel();

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
            details.bookKeeper = (from b in _context.BookKeeper
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

        [HttpPost] 
        public ActionResult AddReview(int rating, string comment, string firstName, string lastName, int id)
        {
            var client = new Client { FirstName = firstName, LastName = lastName, BookKeeperID = id };
            _context.Add(client);
            _context.SaveChanges();

            var clientid = client.ClientID;
            var review = new Reviews { Comment = comment, Rating = rating, BookKeeperID = id, ClientID = clientid};
            _context.Add(review);
            _context.SaveChanges();
            return RedirectToAction("BookkeeperDetails", new { id = id });
        }

    }
}
