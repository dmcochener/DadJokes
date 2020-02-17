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
        public Dictionary<string,List<DisplayJoke>> SortResponses(List<DisplayJoke> responses)
        {
            Dictionary<string, List<DisplayJoke>> sortedResponses = new Dictionary<string, List<DisplayJoke>>
            {
                {"shortJoke", new List<DisplayJoke>() },
                {"midJoke", new List<DisplayJoke>() },
                {"longJoke", new List<DisplayJoke>() }

            };

            foreach (DisplayJoke joke in responses)
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