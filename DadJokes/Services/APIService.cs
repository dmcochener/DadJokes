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
    public class APIService: ApiController
    {
        public async Task<Joke> GetRandomJoke(string url)
        {
            HttpResponseMessage response = APIConnect(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                JokeResponse jsonString = JsonConvert.DeserializeObject<JokeResponse>(responseString);
                var result = new Joke
                {
                    id = jsonString.id,
                    joke = jsonString.joke
                };
                return result;
             }
            else
            {
                var result = new Joke { joke = "Something went wrong and we didn't get a joke." };
                return result;
            }
        }

        public async Task<List<DisplayJoke>> GetManyJokes(string url)
        {
            HttpResponseMessage response = APIConnect(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                MultiJokeResponse jsonString = JsonConvert.DeserializeObject<MultiJokeResponse>(responseString);
                var result = new List<DisplayJoke>();
                foreach(var item in jsonString.results)
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
            else
            {
                var result = new List<DisplayJoke>{
                    new DisplayJoke{ joke = "Something went wrong and we didn't get any joke." }
                };
                return result;
            }
        }

        public async Task<HttpResponseMessage> APIConnect(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);

                return response;
            }
        }

    }
}