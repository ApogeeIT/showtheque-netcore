using System.Collections.Generic;
using ShowTheque.Business.Models;

namespace ShowTheque.Business
{
    public interface IShowRepository
    {
        IEnumerable<Show> GetShows();
        Show GetShow(int id);

        Show AddShow(Show show);

        void DeleteShow(int id);

        Show UpdateShow(Show show);
    }
}