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
        public List<DisplayJoke> SetWordCount(List<DisplayJoke> jokes)
        {
            
            Regex regEx = new Regex("[\\w-]+");
            foreach (var joke in jokes)
            {
                joke.WordCount = regEx.Matches(joke.joke).Count;
            }

            return jokes;
        }

    }
}