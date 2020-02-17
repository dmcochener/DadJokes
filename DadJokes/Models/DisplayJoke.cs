using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DadJokes.Models
{
    //Added elements to be able to count words and highlight content
    public class DisplayJoke: Joke
    {
        public int WordCount { get; set; }
        public string HighlightContent { get; set; }

    }
}