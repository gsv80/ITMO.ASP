﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCR1_fr4._8.Models;

namespace WebMVCR1_fr4._8.Controllers
{
    public class MyController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();


        //}

        public string Index(string hel)
        {   
            string Greeting = ModelClass.ModelHello() + ", " + hel;
            return Greeting;
        }
    }
}