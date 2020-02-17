using DadJokes.Models;
using System;
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
            var joke = new DisplayJoke();
            return View(joke);
        }

        [HttpPost]
        public ActionResult ByTerm(string term)
        {
            var jokes = new Dictionary<string, List<DisplayJoke>>();
            return View(jokes);
        }
    }
}