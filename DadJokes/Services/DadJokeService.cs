using DadJokes.Helpers;
using DadJokes.Services;
using DadJokes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DadJokes.Services
{
    public static class DadJokeService
    {
        
        //Static method to get the basic URL
        public static JokeResponse GetJokes()
        {
            //Set the url for a basic random search
            string url = "https://icanhazdadjoke.com/";
            //Get the processed joke from the API service
            JokeResponse joke = APIService.Service.GetRandomJoke(url);

            return joke;
        }

        //Overload method for search term
        //Set to default 1 page and 30 jokes
        public static Dictionary<string, List<DisplayJoke>> GetJokes(string term)
        {

            //Sets the url with search term
            string url = String.Format("https://icanhazdadjoke.com/search?term={0}&page=1&limit=30", term);
            //Get the processed list of jokes from the API service
            List<DisplayJoke> freshJokes = APIService.Service.GetManyJokes(url);
            //Set the word count for all the jokes
            List<DisplayJoke> countedJokes = CountWords.SetWordCount(freshJokes);
            //Capitalize (aka highlight) the term in all jokes
            List<DisplayJoke> highlightJokes = Highlight.HighlightJokeTerm(countedJokes, term);
            //Sort the responses into 3 lists based on word count
            Dictionary<string, List<DisplayJoke>> finalJokes = Sort.SortResponses(highlightJokes);

            return finalJokes;

        }

        //Could add in future overloads for other options
    }
}