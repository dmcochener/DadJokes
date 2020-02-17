using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DadJokes.Models
{
    public class DisplayJoke: Joke
    {
        public int WordCount { get; set; }
        public string HighlightContent { get; set; }

    }
}