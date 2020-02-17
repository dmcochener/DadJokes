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
            List<DisplayJoke> testJokes = new List<DisplayJoke>
            {
                new DisplayJoke{WordCount = 5 },
                new DisplayJoke{WordCount = 10},
                new DisplayJoke{WordCount = 15},
                new DisplayJoke{WordCount = 20},
                new DisplayJoke{WordCount = 25},
                new DisplayJoke{WordCount = 30},
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
            List<DisplayJoke> testJokes = new List<DisplayJoke>
            {
                new DisplayJoke {joke = "This is a test for seven words."}
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
            List<DisplayJoke> testJokes = new List<DisplayJoke>
            {
                new DisplayJoke {joke = "This is a test for seven words."}
            };

            //Act
            var HighlightWord = filter.HighlightJokeTerm(testJokes, "is");

            Assert.AreEqual(HighlightWord[0].HighlightContent,"ThIS IS a test for seven words.");
        }
    }
}
