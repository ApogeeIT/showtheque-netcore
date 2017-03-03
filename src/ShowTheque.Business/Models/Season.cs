using System.Collections.Generic;

namespace ShowTheque.Business.Models
{
    public class Season
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public IEnumerable<Episode> Episodes { get; set; }
    }
}