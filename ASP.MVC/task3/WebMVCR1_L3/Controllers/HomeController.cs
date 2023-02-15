using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCR1_L3.Models;

namespace WebMVCR1_L3.Controllers
{
    public class HomeController : Controller
    {

        private static PersonRepository db = new PersonRepository();
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greetings = hour < 12 ? "Good Morning" : "Good Day";
            ViewData["Message"] = " see you later";


            return View();
        }

        [HttpGet]
        public ViewResult InputData()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddResponse(p);
            return View("Hello", p);
        }

        public ViewResult OutputData()
        {
            ViewBag.Pers = db.GetAllResponses;
            ViewBag.Count = db.NumberOfPerson;
            return View("ListPerson");
        }
    }
}