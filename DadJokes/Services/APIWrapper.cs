using DadJokes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DadJokes.Services
{
   //Create wrapper class that accesses APIService for testing
    public class APIWrapper : IAPIInterface
    {
        public Task<string> APIConnect(string url)
        {
            return APIService.Service.APIConnect(url);
        }

        public List<DisplayJoke> GetManyJokes(string url)
        {
            return APIService.Service.GetManyJokes(url);
        }

        public JokeResponse GetRandomJoke(string url)
        {
            return APIService.Service.GetRandomJoke(url);
        }
    }
}