using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DadJokes.Models
{
    //Matches the full Json object returned by search
    //Uses the base Joke for the results array
    public class MultiJokeResponse
    {
        public int current_page { get; set; }
        public int limit { get; set; }
        public int next_page { get; set; }
        public int previous_page { get; set; }
        public IList<Joke> results { get; set; }
        public string search_term { get; set; }
        public int status { get; set; }
        public int total_jokes { get; set; }
        public int total_pages { get; set; }

    }
}