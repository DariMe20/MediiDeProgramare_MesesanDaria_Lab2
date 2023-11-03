﻿using System.ComponentModel.DataAnnotations;

namespace MediiDeProgramare_MesesanDaria_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
 
        public ICollection<Book>? Books { get; set; } //navigation property

        [Display(Name = "Author Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

    }
}
