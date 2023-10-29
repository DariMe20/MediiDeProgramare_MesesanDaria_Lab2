using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MediiDeProgramare_MesesanDaria_Lab2.Models;

namespace MediiDeProgramare_MesesanDaria_Lab2.Data
{
    public class MediiDeProgramare_MesesanDaria_Lab2Context : DbContext
    {
        public MediiDeProgramare_MesesanDaria_Lab2Context (DbContextOptions<MediiDeProgramare_MesesanDaria_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<MediiDeProgramare_MesesanDaria_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<MediiDeProgramare_MesesanDaria_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<MediiDeProgramare_MesesanDaria_Lab2.Models.Author>? Author { get; set; }

        public DbSet<MediiDeProgramare_MesesanDaria_Lab2.Models.Category>? Category { get; set; }
    }
}
