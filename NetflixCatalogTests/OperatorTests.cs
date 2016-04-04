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
    public class GenreTests
    {
        [TestMethod()]
        public void OpperatorTestOne()
        {
            //arrange
            Genre genreOne = new Genre();
            Genre genreTwo = new Genre();
            Movie movie = new Movie("Movie One", 5, 10);
            Show show = new Show("Show One", 5);
            genreOne.titleList.Add(movie);
            genreTwo.titleList.Add(show);
            //act
            genreOne += genreTwo;
            //assert
            Assert.AreEqual(2, genreOne.titleList.Count);
        }
        [TestMethod()]
        public void OpperatorTestTwo()
        {
            //arrange
            Genre genreOne = new Genre();
            Movie movie = new Movie("Movie One", 5, 10);
            //act
            genreOne += movie;
            //assert
            Assert.AreEqual(1, genreOne.titleList.Count);
        }
        [TestMethod()]
        public void OpperatorTestThree()
        {
            Genre genreOne = new Genre();
            Movie movie = new Movie("Movie One", 5, 10);
            Show show = new Show("Show One", 5);
            //act
            genreOne += (movie+show);
            //assert
            Assert.AreEqual(2, genreOne.titleList.Count);
        }
    }
}