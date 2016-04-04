using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogSystem
{
    public class Catalog
    {
        List<Genre> genres = new List<Genre>();
        Genre superGenre = new Genre();
        View view = new View();

        public Catalog()
        {
            double? nullDouble = null;

            Genre action = new Genre();
            Genre comedy = new Genre();
            Genre romance = new Genre();

            genres.Add(action);
            genres.Add(comedy);
            genres.Add(romance);

            Movie actionMovieOne = new Movie("Action Cop", 5, 12000);
            Movie actionMovieTwo = new Movie("Action Man 16", 1, 11200);
            Movie actionMovieThree = new Movie("Action Cars 7", 4, 15200);
            Movie comedyMovieOne = new Movie("Comedy Bang Bang", nullDouble, nullDouble);
            Movie comedyMovieTwo = new Movie("Comedy Haha", 4, 11500);
            Movie comedyMovieThree = new Movie("Comedy Laughs", 2, 12500);
            Movie romanceMovieOne = new Movie("Romance Event of The Year", 3, 13500);
            Movie romanceMovieTwo = new Movie("Romance Beach", 5, 11500);
            Movie romanceMovieThree = new Movie("Cool People 2", 2, 11900);
            
            Show actionShowOne = new Show("Dr. What?", 5);
            Show actionShowTwo = new Show("The Catastrophy", nullDouble);
            Show actionShowThree = new Show("Trent in Action", 3);
            Show comedyShowOne = new Show("Mr. Jongle's Adventrues", 3);
            Show comedyShowTwo = new Show("Weekly Sketch Show", 2);
            Show comedyShowThree = new Show("People in New York", 4);
            Show romanceShowOne = new Show("Drama for an Hour", 1);
            Show romanceShowTwo = new Show("This Sweet House", 5);
            Show romanceShowThree = new Show("Weekly Romance", 4);

            actionShowOne.episodes.Add(new Episode("Episode One", 5, 1320));
            actionShowOne.episodes.Add(new Episode("Episode Two", 2, 1340));
            actionShowOne.episodes.Add(new Episode("Episode Three", 4, 1536));
            actionShowTwo.episodes.Add(new Episode("Episode One", 3, 1667));
            actionShowTwo.episodes.Add(new Episode("Episode Two", 2, 1620));
            actionShowTwo.episodes.Add(new Episode("Episode Three", 4, 1536));
            actionShowThree.episodes.Add(new Episode("Episode One", 5, 1381));
            actionShowThree.episodes.Add(new Episode("Episode Two", 2, 1260));
            actionShowThree.episodes.Add(new Episode("Episode Three", 1, 1436));

            comedyShowOne.episodes.Add(new Episode("Episode One", 5, 1500));
            comedyShowOne.episodes.Add(new Episode("Episode Two", 2, 1320));
            comedyShowOne.episodes.Add(new Episode("Episode Three", 4, 1536));
            comedyShowTwo.episodes.Add(new Episode("Episode One", 3, 1167));
            comedyShowTwo.episodes.Add(new Episode("Episode Two", 2, 1520));
            comedyShowTwo.episodes.Add(new Episode("Episode Three", 4, 1536));
            comedyShowThree.episodes.Add(new Episode("Episode One", 5, 1200));
            comedyShowThree.episodes.Add(new Episode("Episode Two", 2, 1160));
            comedyShowThree.episodes.Add(new Episode("Episode Three", 1, 1436));

            romanceShowOne.episodes.Add(new Episode("Episode One", 5, 1500));
            romanceShowOne.episodes.Add(new Episode("Episode Two", 2, 1620));
            romanceShowOne.episodes.Add(new Episode("Episode Three", 4, 1536));
            romanceShowTwo.episodes.Add(new Episode("Episode One", 3, 1567));
            romanceShowTwo.episodes.Add(new Episode("Episode Two", 2, 1320));
            romanceShowTwo.episodes.Add(new Episode("Episode Three", 4, 1536));
            romanceShowThree.episodes.Add(new Episode("Episode One", 5, 1500));
            romanceShowThree.episodes.Add(new Episode("Episode Two", 2, 1530));
            romanceShowThree.episodes.Add(new Episode("Episode Three", 1, 1436));

            genres[0] += actionMovieOne;
            genres[0] += actionMovieTwo;
            genres[0] += actionMovieThree;
            genres[0] += actionShowOne;
            genres[0] += actionShowTwo;
            genres[0] += actionShowThree;
            genres[1] += comedyMovieOne;
            genres[1] += comedyMovieTwo;
            genres[1] += comedyMovieThree;
            genres[1] += comedyShowOne;
            genres[1] += comedyShowTwo;
            genres[1] += comedyShowThree;
            genres[2] += romanceMovieOne;
            genres[2] += romanceMovieTwo;
            genres[2] += romanceMovieThree;
            genres[2] += romanceShowOne;
            genres[2] += romanceShowTwo;
            genres[2] += romanceShowThree;


            Movie superMovie = new Movie("Super Movie", 5, 12000); 
            Show superShow = new Show("Dr. What Returns", 5);
            superShow.episodes.Add(new Episode("Super Episode One", 5, 1500));
            superShow.episodes.Add(new Episode("Super Episode Two", 2, 1320));
            superShow.episodes.Add(new Episode("Super Episode Three", 4, 1536));
            superGenre = superMovie + superShow;
            superGenre += genres[0];
            superGenre += genres[1];
            superGenre += genres[2];

        }
        public void PrintCatalog()
        {
            view.PrintCatalog(genres);
            Console.WriteLine();
            view.PrintGenre(superGenre);
        }
        
    }
}
