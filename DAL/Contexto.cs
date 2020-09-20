using Microsoft.EntityFrameworkCore;
using RegistroReal.Models;

namespace RegistroReal.DAL{
    class Contexto : DbContext{
        public DbSet<Persona> Persona {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source= Data/Registro.db");
        }
    }
}