using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DadJokes.Services
{
    public class DadUrl
    {

        public string DadJokeUrl()
        {
            string url = "https://icanhazdadjoke.com/";

            return url;
        }

        //Overload method for search term
        //Set to default 1 page and 30 jokes
        public string DadJokeUrl(string term)
        {
            string url = String.Format("https://icanhazdadjoke.com/search?term={0}&page=1&limit=30", term);

            return url;
        }
    }
}