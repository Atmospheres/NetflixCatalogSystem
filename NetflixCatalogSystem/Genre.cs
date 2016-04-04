using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace NetflixCatalogSystem
{
    public class Genre : IEnumerable<Title>
    {
        public List<Title> titleList = new List<Title>();
        public IEnumerator<Title> GetEnumerator()
        {
            return this.titleList.GetEnumerator();  

        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < titleList.Count; i++)
            {
                yield return titleList[i];
            }
        }
        public static Genre operator +(Genre genreOne, Genre genreTwo)
        {
            Genre genre = new Genre();
            for (int i = 0; i < genreOne.titleList.Count; i++)
            {
                genre.titleList.Add(genreOne.titleList[i]);
            }
            for (int i = 0; i < genreTwo.titleList.Count; i++)
            {
                genre.titleList.Add(genreTwo.titleList[i]);
            }
            return genre;
        }
        public static Genre operator +(Genre genreOne, Title titleOne)
        {
            genreOne.titleList.Add(titleOne);
            return genreOne;
        }
    }

}
