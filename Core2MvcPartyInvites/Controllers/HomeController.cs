using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core2MvcPartyInvites.Models;

namespace Core2MvcPartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Invite");
        }

        [HttpGet]
        public IActionResult Reply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Reply(Guest guest)
        {
            if(ModelState.IsValid)
            {
                Responses.AddResponse(guest);
                return View("Thanks", guest);
            }
            else
            {
                return View();
            }
        }

        public IActionResult ListAttendees(Guest guest)
        {
            var attendees = Responses.GetAttendees.Where(r => r.WillAttend == true);

            return View(attendees);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
