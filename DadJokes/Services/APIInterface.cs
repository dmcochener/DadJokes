using DadJokes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadJokes.Services
{
    //Create interface for API Service to implement unit tests
    public interface IAPIInterface
    {
        JokeResponse GetRandomJoke(string url);
        List<DisplayJoke> GetManyJokes(string url);
        Task<string> APIConnect(string url);

    }
}
