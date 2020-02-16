using DadJokes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace DadJokes.Helpers
{
    public class CountWords
    {
        public List<Joke> SetWordCount(List<Joke> jokes)
        {
            
            Regex regEx = new Regex("[\\w-]+");
            foreach (var joke in jokes)
            {
                joke.WordCount = regEx.Matches(joke.Content).Count;
            }

            return jokes;
        }

    }
}