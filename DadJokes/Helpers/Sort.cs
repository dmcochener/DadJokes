using DadJokes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DadJokes.Helpers
{
    public static class Sort
    {
        //Creating a simple sort method based on word count
        //This reduces the BigO notation versus the built in Sort method
        public static Dictionary<string,List<DisplayJoke>> SortResponses(List<DisplayJoke> responses)
        {
            //Create base dictionary for sorting jokes by length
            Dictionary<string, List<DisplayJoke>> sortedResponses = new Dictionary<string, List<DisplayJoke>>
            {
                {"shortJoke", new List<DisplayJoke>() },
                {"midJoke", new List<DisplayJoke>() },
                {"longJoke", new List<DisplayJoke>() }

            };
            //Sort each joke by word count, assumes that value is set
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