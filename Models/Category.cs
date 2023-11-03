using System.ComponentModel.DataAnnotations;

namespace MediiDeProgramare_MesesanDaria_Lab2.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<BookCategory>? BookCategory { get; set; }
    }
}
