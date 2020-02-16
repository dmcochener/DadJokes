using DadJokes.Helpers;
using DadJokes.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadJokes.Tests.Helpers
{
    [TestClass]
    public class HelpersTest
    {
        [TestMethod]
        public void SortJokes()
        {
            //Arrange
            Sort sorter = new Sort();
            List<Joke> testJokes = new List<Joke>
            {
                new Joke{WordCount = 5 },
                new Joke{WordCount = 10},
                new Joke{WordCount = 15},
                new Joke{WordCount = 20},
                new Joke{WordCount = 25},
                new Joke{WordCount = 30},
            };

            //Act
            var sortResult = sorter.SortResponses(testJokes);

            //Assert
            Assert.AreEqual(sortResult["shortJoke"].Count, 1);
            Assert.AreEqual(sortResult["midJoke"].Count, 2);
            Assert.AreEqual(sortResult["longJoke"].Count, 3);

        }

        [TestMethod]
        public void WordCount()
        {
            //Arrange
            CountWords counter = new CountWords();
            List<Joke> testJokes = new List<Joke>
            {
                new Joke {Content = "This is a test for seven words."}
            };

            //Act
            var countedWords = counter.SetWordCount(testJokes);

            //Assert
            Assert.AreEqual(countedWords[0].WordCount, 7);

        }

        [TestMethod]
        public void HighlightText()
        {
            //Arrange
            Filter filter = new Filter();
            List<Joke> testJokes = new List<Joke>
            {
                new Joke {Content = "This is a test for seven words."}
            };

            //Act
            var HighlightWord = filter.HighlightJokeTerm(testJokes, "is");

            Assert.AreEqual(HighlightWord[0].HighlightContent,"ThIS IS a test for seven words.");
        }
    }
}
