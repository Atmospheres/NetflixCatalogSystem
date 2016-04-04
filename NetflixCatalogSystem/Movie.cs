using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogSystem
{
    public class Movie : Title
    {
        string name;
        double? rating;
        double? durration;
        //Overrides ToString() method to return a string of the name and duration of the movie
        public Movie()
        {

        }
        public Movie(string name, double? rating, double? durration)
        {
            this.name = name;
            this.rating = rating;
            this.durration = durration;
        }
        public override string ToString()
        {
            string movie = string.Format("Movie Name: {0} Durraration: {1} Rating: {2}", name, durration, rating);
            return movie;
        }
    }
}
