using DadJokes.Models;
using DadJokes.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DadJokes.Tests.Services
{
    [TestClass]
    public class ServicesTest
    {
        [TestMethod]
        public void APIService()
        {
            //Arrange
            string url = "https://icanhazdadjoke.com/j/EQKZDIeah";
            APIService service = new APIService();

            //Act
            var response = service.APIConnect(url);

            //Assert
            Assert.IsNotNull(response.Result);
        }

        [TestMethod]
        public void GetJoke()
        {
            //Arrange
            string url = "https://icanhazdadjoke.com/j/EQKZDIeah";
            APIService service = new APIService();

            //Act
            Joke _joke = service.GetRandomJoke(url).Result;

            //Assert
            Assert.AreEqual(_joke.id, "EQKZDIeah");
        }


       [TestMethod]
       public void SearchJokes()
        {
            //Arrange
            string url = "https://icanhazdadjoke.com/search?term=funny";
            APIService service = new APIService();

            //Act
            List<DisplayJoke> _jokes = service.GetManyJokes(url).Result;

            //Assert
            Assert.AreEqual(_jokes.Count, 2);
        }
    }
}
