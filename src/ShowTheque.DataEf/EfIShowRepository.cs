using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ShowTheque.Business;
using ShowTheque.Business.Models;

namespace ShowTheque.DataEf
{
    public class EfShowRepository : IShowRepository
    {
        private ShowDbContext _db;

        public EfShowRepository(ShowDbContext db)
        {
            _db = db;
        }

        public Show AddShow(Show show)
        {
            _db.Shows.Add(show);
            _db.SaveChanges();
            return show;
        }

        public void DeleteShow(int id)
        {
            var show = _db.Shows.Find(id);
            if (show != null)
            {
                _db.Shows.Remove(show);
                _db.SaveChanges();
            }
        }

        public Show GetShow(int id)
        {
            return _db.Shows.Include(s => s.Seasons)
                .ThenInclude(e => e.Episodes)
                .FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Show> GetShows()
        {
            return _db.Shows.Include(s => s.Seasons)
                .ThenInclude(e => e.Episodes)
                .ToList();
        }

        public Show UpdateShow(Show show)
        {
            _db.Shows.Update(show);
            _db.SaveChanges();
            return show;
        }
    }
}
