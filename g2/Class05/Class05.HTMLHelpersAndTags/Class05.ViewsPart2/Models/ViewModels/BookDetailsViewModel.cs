using Class05.ViewsPart2.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace Class05.ViewsPart2.Models.ViewModels
{
    public class BookDetailsViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Book title")]
        public string Title { get; set; }
        [Display(Name = "Book author")]
        public string AuthorFullName { get; set; }
        [Display(Name = "Book genre")]
        public Genre Genre { get; set; }
    }
}
