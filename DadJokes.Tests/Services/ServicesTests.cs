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
        //Create instance of wrapper for testing
        APIWrapper _APIWrapper = new APIWrapper();
       
        [TestMethod]
        public void APIService()
        {
            
            //Arrange
            string url = "https://icanhazdadjoke.com/";

            //Act
            var response = _APIWrapper.APIConnect(url);

            //Assert
            Assert.IsNotNull(response.Result);
        }

        [TestMethod]
        public void GetJoke()
        {
            //Arrange
            string url = "https://icanhazdadjoke.com/j/EQKZDIeah";

            //Act
            Joke _joke = _APIWrapper.GetRandomJoke(url);

            //Assert
            Assert.AreEqual(_joke.id, "EQKZDIeah");
        }


       [TestMethod]
       public void SearchJokes()
        {
            //Arrange
            string url = "https://icanhazdadjoke.com/search?term=funny";

            //Act
            List<DisplayJoke> _jokes = _APIWrapper.GetManyJokes(url);

            //Assert
            Assert.AreEqual(_jokes.Count, 2);
        }

    }
}
