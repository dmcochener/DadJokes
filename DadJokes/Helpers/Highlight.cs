using DadJokes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace DadJokes.Helpers
{
    public static class Highlight
    {
        public static List<DisplayJoke> HighlightJokeTerm(List<DisplayJoke> jokes, string term)
        {
            //Creates a string to highlight the term
            string replace = term.ToUpper();
            //Regular expression to find the term
            Regex regEx = new Regex(term);
            //Iterate through jokes replacing the term with the replace string
            foreach(var joke in jokes)
            {
                joke.HighlightContent = regEx.Replace(joke.joke, replace);
            }
            return jokes;
        }

    }
}