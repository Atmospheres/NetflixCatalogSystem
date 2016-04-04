using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogSystem
{
    public class View
    {
        public void PrintCatalog(List<Genre> genres)
        {
            for(int i = 0; i < genres.Count; i++)
            {
                PrintGenre(genres[i]);
            }
        }
        public void PrintGenre(Genre genre)
        {
            foreach(Title title in genre)
            {
                Console.WriteLine(title.ToString());
            }
        }
    }
}
