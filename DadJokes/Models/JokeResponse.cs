using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DadJokes.Models
{
    public class JokeResponse: Joke
    {
        public int status { get; set; }

    }
}