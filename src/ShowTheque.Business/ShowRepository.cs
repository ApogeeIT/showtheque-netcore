using System.Collections.Generic;
using System.Linq;
using ShowTheque.Business.Models;

namespace ShowTheque.Business
{
    public class ShowRepository : IShowRepository
    {

        private readonly List<Show> Shows;

        public ShowRepository ()
        {
            Shows = new List<Show> {
                new Show{Id = 1, Title = "Sence 8"},
                new Show{Id = 2, Title = "The Expanse"}
            };
        }

        public IEnumerable<Show> GetShows()
        {
            return Shows;
        }
        public Show GetShow(int id)
        {
            return Shows.FirstOrDefault(s => s.Id == id);
        }

        public Show AddShow(Show show)
        {
            show.Id = Shows.Any() ? Shows.Max(s => s.Id) + 1 : 1;
            Shows.Add(show);
            return show;
        }

        public void DeleteShow(int id)
        {
            var showToRemove = GetShow(id);
            if(showToRemove != null)
            {
                Shows.Remove(showToRemove);
            }
        }

        public Show UpdateShow(Show show)
        {
            DeleteShow(show.Id);
            Shows.Add(show);
            return show;
        }
    }
}