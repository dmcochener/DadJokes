using DadJokes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace DadJokes.Helpers
{
    public static class CountWords
    {
        public static List<DisplayJoke> SetWordCount(List<DisplayJoke> jokes)
        {
            
            //Regular expression for finding word objects
            Regex regEx = new Regex("[\\w-]+");
            //Iterate through jokes to count number of words, set property
            foreach (var joke in jokes)
            {
                joke.WordCount = regEx.Matches(joke.joke).Count;
            }

            return jokes;
        }

    }
}