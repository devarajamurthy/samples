using SeminarInvite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeminarInvite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();

        }

        public ViewResult Register()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Register(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                using (var context = new GuestDbContext())
                {
                    context.GuestResponses.Add(guestResponse);
                    context.SaveChanges();
                }

                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }

        }

    }
}