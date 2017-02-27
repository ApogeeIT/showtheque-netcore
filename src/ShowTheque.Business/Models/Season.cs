namespace ShowTheque.Business.Models
{
    public class Season
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public Episode[] Episodes { get; set; }
    }
}