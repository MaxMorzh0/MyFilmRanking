using System.ComponentModel.DataAnnotations;

namespace MyFilmRanking.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public string Director { get; set; }

        public int Budget { get; set; }

        public string Genre { get; set; }

    }
}
