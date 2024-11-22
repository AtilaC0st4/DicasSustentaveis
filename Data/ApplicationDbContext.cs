using DicasSustentaveisGS1.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DicasSustentaveisGS1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Frase> Frases { get; set; }
        public DbSet<FrasePreferida> FrasesPreferidas { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}