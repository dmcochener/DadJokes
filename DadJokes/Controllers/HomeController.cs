﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DadJokes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Random()
        {
            return View();
        }

        public ActionResult ByTerm(string term)
        {
            return View();
        }
    }
}