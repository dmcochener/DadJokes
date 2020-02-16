using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DadJokes.Models
{
    public class Joke
    {
        public string Content { get; set; }
        public int WordCount { get; set; }
        public string HighlightContent { get; set; }

    }
}