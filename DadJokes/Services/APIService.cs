using DadJokes.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace DadJokes.Services
{
    public sealed class APIService : ApiController
    {
        //Code to make service a Singleton to reduce instances
        private APIService()
        {

        }
        private static APIService service = null;
        public static APIService Service
        {
            get
            {
                if (service == null)
                {
                    service = new APIService();
                }
                return service;
            }
        }

        public JokeResponse GetRandomJoke(string url)
        {
            //Gets response from API
            string responseString = APIConnect(url).Result;
            //Converts Json String to joke response type object
            JokeResponse jokeObject = JsonConvert.DeserializeObject<JokeResponse>(responseString);

            return jokeObject;

        }

        public List<DisplayJoke> GetManyJokes(string url)
        {
            //Gets Json string of response
            string responseString = APIConnect(url).Result;
            //Converts response into Multi Joke Object
            MultiJokeResponse multiJoke = JsonConvert.DeserializeObject<MultiJokeResponse>(responseString);
            //Creates new list to store jokes
            var result = new List<DisplayJoke>();
            //Iterates through list of jokes to create display jokes for sorting and filtering
            foreach (var item in multiJoke.results)
            {
                var display = new DisplayJoke
                {
                    id = item.id,
                    joke = item.joke
                };
                result.Add(display);

            };
            return result;

        }

        public async Task<string> APIConnect(string url)
        {
            //Sets up HttpClient for accessing API
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                //Gets response from url passed in
                HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);
                //Checks for success
                if (response.IsSuccessStatusCode)
                {
                    //Converts response to Json string
                    string responseString = await response.Content.ReadAsStringAsync();
                    return responseString;
                }
                //Throws an error if there was a bad response code.
                else
                {
                    throw new Exception("Something went wrong and we didn't connect to the API.");
                }
            }

        }
    }
}