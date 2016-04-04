using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogSystem
{
    public class Episode
    {
        public string name;
        public double? rating;
        public double? durration;

        public Episode()
        {

        }
        public Episode(string name, double? rating, double? durration)
        {
            this.name = name;
            this.rating = rating;
            this.durration = durration;
        }
    }
}
