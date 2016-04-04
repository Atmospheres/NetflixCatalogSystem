using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetflixCatalogSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogSystem.Tests
{
    [TestClass()]
    public class ShowTests
    {
        [TestMethod()]
        public void AddEpisodeTestOne()
        {
            //arange
            Show show = new Show();
            Episode episode = new Episode();
            int countBefore = show.episodes.Count();
            //act
            show.AddEpisode(show, episode);
            int countAfter = show.episodes.Count();       
            //assert
            Assert.AreEqual(countBefore + 1, countAfter);
        }
        [TestMethod()]
        public void AddEpisodeTestTwo()
        {
            //arange
            Show show = new Show();
            Episode episode = new Episode("Episode One", 10, 300);
            //act
            show.AddEpisode(show, episode);
            //assert
            Assert.AreSame("Episode One", show.episodes[show.episodes.Count - 1].name);
            Assert.AreEqual(10, show.episodes[show.episodes.Count - 1].rating);
            Assert.AreEqual(300, show.episodes[show.episodes.Count - 1].durration);
        }
        [TestMethod()]
        public void AddEpisodeTestThree()
        {
            //arange
            Show show = new Show();
            Episode episode = new Episode("Episode One", 10, 300);
            //act
            for (int i = 1; i <= 50000000; i++)
            {
                show.AddEpisode(show, episode);
            }
            //assert
            Assert.AreEqual(50000000, show.episodes.Count);
        }
        [TestMethod()]
        public void AddEpisodeTestFour()
        {
            //arange
            Show show = new Show();
            Episode episode = new Episode("Episode One", 10, 300);
            //act
            for (int i = 1; i <= 50000000; i++)
            {
                show.AddEpisode(show, episode);
            }
            //assert
            Assert.AreSame("Episode One", show.episodes[41042450].name);
            Assert.AreEqual(10, show.episodes[19460034].rating);
            Assert.AreEqual(300, show.episodes[23467].durration);
        }
        [TestMethod()]
        public void RatingTestOne()
        {
            //arange
            Show show = new Show();
            Episode episodeOne = new Episode("Episode One", 10, 300);
            Episode episodeTwo = new Episode("Episode Two", 3, 300);
            Episode episodeThree = new Episode("Episode Three", 7, 300);
            show.episodes.Add(episodeOne);
            show.episodes.Add(episodeTwo);
            show.episodes.Add(episodeThree);
            double total = 20;
            double divideBy = 3;
            double? ratingCompare = (total / divideBy);
            //act
            double? ratingReturn = show.Rating;
            //assert
            Assert.AreEqual(ratingCompare, ratingReturn);
        }
        [TestMethod()]
        public void RatingTestTwo()
        {
            //arange
            Show show = new Show();
            double? nullDouble = null;
            Episode episodeOne = new Episode("Episode One", nullDouble, 300);
            Episode episodeTwo = new Episode("Episode Two", 3, 300);
            Episode episodeThree = new Episode("Episode Three", 7, 300);
            show.episodes.Add(episodeOne);
            show.episodes.Add(episodeTwo);
            show.episodes.Add(episodeThree);
            double total = 10;
            double divideBy = 2;
            double? ratingCompare = (total / divideBy);
            //act
            double? ratingReturn = show.Rating;
            //assert
            Assert.AreEqual(ratingCompare, ratingReturn);
        }
        [TestMethod()]
        public void RatingTestThree()
        {
            //arange
            Show show = new Show();
            double? nullDouble = null;
            Episode episodeOne = new Episode("Episode One", nullDouble, 300);
            Episode episodeTwo = new Episode("Episode Two", nullDouble, 300);
            Episode episodeThree = new Episode("Episode Three", nullDouble, 300);
            show.episodes.Add(episodeOne);
            show.episodes.Add(episodeTwo);
            show.episodes.Add(episodeThree);

            //act
            double? ratingReturn = show.Rating;
            //assert
            Assert.AreEqual(null, ratingReturn);
        }
    }
}