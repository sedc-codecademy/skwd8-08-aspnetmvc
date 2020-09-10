using Class05.ViewsPart2.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace Class05.ViewsPart2.Models.ViewModels
{
    public class BookCreateViewModel
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        [Display(Name = "Author fullname")]
        public string AuthorFullName { get; set; }
        [Display(Name = "Author age")]
        public int? AuthorAge { get; set; }
        public Genre Genre { get; set; }
        [Display(Name = "Availability")]
        public bool IsAvailable { get; set; }
    }
}
