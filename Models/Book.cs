using System.ComponentModel.DataAnnotations;

namespace _1670Project.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Title { get; set; }

        public string Author { get; set; }

        public string ImageUrl {  get; set; }

        public decimal? Price { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }

        public Genre? Genre { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public int BookNumber { get; set; }

    }
}
