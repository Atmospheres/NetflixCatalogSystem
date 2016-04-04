using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogSystem
{
    abstract public class Title
    {
        
        
        public string name;
        protected double? rating;
        public virtual double? Rating
        {
            get
            {
                return rating;
            }
        }
        public Title(string name, double rating)
        {
            this.name = name;
            this.rating = rating;
        }
        public Title()
        {

        }
        public static Genre operator +(Title titleOne, Title titleTwo)
        {
            Genre genre = new Genre();
            genre.titleList.Add(titleOne);
            genre.titleList.Add(titleTwo);
            return genre;
        }
    }
}
