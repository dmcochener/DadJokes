﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DadJokes.Services
{
    public static class DadUrl
    {

        //Static method to get the basic URL
        public static string DadJokeUrl()
        {
            string url = "https://icanhazdadjoke.com/";

            return url;
        }

        //Overload method for search term
        //Set to default 1 page and 30 jokes
        public static string DadJokeUrl(string term)
        {
            string url = String.Format("https://icanhazdadjoke.com/search?term={0}&page=1&limit=30", term);

            return url;
        }

        //Could add in future overloads for other options
    }
}