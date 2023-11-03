﻿using MediiDeProgramare_MesesanDaria_Lab2.Models.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace MediiDeProgramare_MesesanDaria_Lab2.Models
{
    public class BookCategory
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
