using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ASP.ExamTask.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult InputData()
        {
            return View();   
        }

        [HttpPost]
        public ViewResult InputData(Students s)
        {
            return View("Table", s);
        }


    }
}