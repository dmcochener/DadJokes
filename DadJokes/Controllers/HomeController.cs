using DadJokes.Models;
using DadJokes.Services;
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
                //Get random joke
                Joke joke = DadJokeService.GetJokes();
                
                //Send the joke to the view
                return View(joke);
        }


        [HttpPost]
        public ActionResult ByTerm(string term)
        {
                // Get the url for the specific search term
                var jokes = DadJokeService.GetJokes(term);

                //Send list of jokes to view
                return View(jokes);
        }
    }
}