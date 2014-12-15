using Week6CodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week6CodeChallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Work()
        {
            return View();
        }

        public ActionResult Careers()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            Models.W6ContactForm contactForm = new Models.W6ContactForm();
            return View(contactForm);
        }

        [HttpPost]
        public ActionResult Contact(Models.W6ContactForm contactForm)
        {
            Models.ContactEntities db = new Models.ContactEntities();
            db.W6ContactForms.Add(contactForm);
            db.SaveChanges();
            return RedirectToAction("ThankYou", "Home");
        }

        public ActionResult Who()
        {
            return View();
        }

        public ActionResult What()
        {
            return View();
        }

        public ActionResult Why()
        {
            return View();
        }

        public ActionResult How()
        {
            return View();
        }

        public ActionResult Where()
        {
            return View();
        }
    }
}