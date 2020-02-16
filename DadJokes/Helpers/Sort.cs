using DadJokes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DadJokes.Helpers
{
    public class Sort
    {
        //Creating a simple sort method based on word count
        //This reduces the BigO notation versus the built in Sort method
        public Dictionary<string,List<Joke>> SortResponses(List<Joke> responses)
        {
            Dictionary<string, List<Joke>> sortedResponses = new Dictionary<string, List<Joke>>
            {
                {"shortJoke", new List<Joke>() },
                {"midJoke", new List<Joke>() },
                {"longJoke", new List<Joke>() }

            };

            foreach (Joke joke in responses)
            {
                if (joke.WordCount < 10)
                {
                    sortedResponses["shortJoke"].Add(joke);
                }
                else if (joke.WordCount < 20)
                {
                    sortedResponses["midJoke"].Add(joke);
                }
                else
                {
                    sortedResponses["longJoke"].Add(joke);
                }
            }


            return sortedResponses;
        }
    }
}