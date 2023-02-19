using ASP.ExamTask.Models;
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
        public ViewResult InputData(Student s)
        {
            try{
                    SchoolContext ctx = new SchoolContext();
                
                    ctx.Students.Add(s);
                    ctx.SaveChanges();
                

            }
            catch (Exception e)
            {
                Response.Redirect("Table" + e.Message);
            }
                return View("Table", s);
        }


    }
}