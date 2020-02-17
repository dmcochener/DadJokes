using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DadJokes.Models
{
    //For single joke response, includes status for model
    public class JokeResponse: Joke
    {
        public int status { get; set; }

    }
}