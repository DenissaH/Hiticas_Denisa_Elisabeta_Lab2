using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hiticas_Denisa_Elisabeta_Lab2.Models;

namespace Hiticas_Denisa_Elisabeta_Lab2.Data
{
    public class Hiticas_Denisa_Elisabeta_Lab2Context : DbContext
    {
        public Hiticas_Denisa_Elisabeta_Lab2Context (DbContextOptions<Hiticas_Denisa_Elisabeta_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Hiticas_Denisa_Elisabeta_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Hiticas_Denisa_Elisabeta_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Hiticas_Denisa_Elisabeta_Lab2.Models.Author>? Author { get; set; }

    }
}
