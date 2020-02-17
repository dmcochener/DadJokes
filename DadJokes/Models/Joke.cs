using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DadJokes.Models
{
    //Basic joke returned from API, parent model for others
    public class Joke
    {
        public string id { get; set; }
        public string joke { get; set; }
    }
}