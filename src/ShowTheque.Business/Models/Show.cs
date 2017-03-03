using System.Collections.Generic;

namespace ShowTheque.Business.Models
{
    public class Show
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public IEnumerable<Season> Seasons { get; set; }
    }
}