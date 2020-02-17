using DadJokes.Models;
using DadJokes.Services;
using DadJokes.Helpers;
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
           using(APIService service = new APIService())
            {
                //Get the url for a basic random search
                string url = DadUrl.DadJokeUrl();
                //Get the processed joke from the API service
                Joke joke = service.GetRandomJoke(url).Result;
                //Send the joke to the view
                return View(joke);
            }
        }


        [HttpPost]
        public ActionResult ByTerm(string term)
        {
            using (APIService service = new APIService())
            {
                // Get the url for the specific search term
                string url = DadUrl.DadJokeUrl(term);
                //Get the processed list of jokes from the API service
                List<DisplayJoke> freshJokes = service.GetManyJokes(url).Result;
                //Set the word count for all the jokes
                List<DisplayJoke> countedJokes = CountWords.SetWordCount(freshJokes);
                //Capitalize (aka highlight) the term in all jokes
                List<DisplayJoke> highlightJokes = Highlight.HighlightJokeTerm(countedJokes, term);
                //Sort the responses into 3 lists based on word count
                Dictionary<string, List<DisplayJoke>> finalJokes = Sort.SortResponses(highlightJokes);
                //Send final list of jokes to view
                return View(finalJokes);
            }
        }
    }
}