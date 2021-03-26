using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookKeeping.Controllers
{
    public class ScheduleController : Controller
    {
        public IActionResult BookkeeperList()
        {
            return View();
        }

        public IActionResult BookkeeperDetails()
        {
            return View(); 
        } 
    }
}
