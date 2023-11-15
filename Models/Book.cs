using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace MediiDeProgramare_MesesanDaria_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Titlul cărții este obligatoriu.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Lungimea titlului trebuie să fie între 3 și 150 de caractere.")]
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        public Author? Author { get; set; }
        public int AuthorID { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate { get; set; }

        public int PublisherID { get; set; }
        public Publisher? Publisher { get; set; }


        [Display(Name = "Book Category")]
        public ICollection<BookCategory>? BookCategories { get; set; }

        public Borrowing? Borrowing { get; set; }
    }
}


