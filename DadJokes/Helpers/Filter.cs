using DadJokes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace DadJokes.Helpers
{
    public class Filter
    {
        public List<Joke> HighlightJokeTerm(List<Joke> jokes, string term)
        {
            string replace = term.ToUpper();
            Regex regEx = new Regex(term);
            foreach(var joke in jokes)
            {
                joke.HighlightContent = regEx.Replace(joke.Content, replace);
            }
            return jokes;
        }

    }
}