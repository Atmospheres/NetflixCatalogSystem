using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogSystem
{
    public class Show : Title
    {
        public List<Episode> episodes = new List<Episode>();
        public string name;
        public override double? Rating
        {
            get
            {
                rating = 0;
                int ratingCount = 0;
                for (int i = 0; i < episodes.Count; i++)
                {
                    if (episodes[i].rating != null)
                    {
                        rating += episodes[i].rating;
                        ratingCount ++; 
                    }
                }
                if (rating != 0)
                {
                    rating = (rating / ratingCount);
                }
                else if (rating == 0)
                {
                    rating = null;
                }
                return rating;
            }
        }
        public Show()
        {

        }
        public Show(string name, double? rating)
        {
            this.name = name;
            this.rating = rating;
        }
        public Show AddEpisode(Show show, Episode episode)
        {
            show.episodes.Add(episode);
            return show;
        }
        public override string ToString()
        {
            string show;
            show = string.Format("Show Name: {0} Rating:{1} Episodes: {2}", name, Rating, episodes.Count);
            for (int i = 0; i < episodes.Count; i++)
            {
                show += string.Format("\n\tEpisode:{0} Rating:{1} Durration: {2}", episodes[i].name, episodes[i].rating, episodes[i].durration);
            }
            return show;
        }
    }
}
