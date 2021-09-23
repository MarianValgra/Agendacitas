using Microsoft.EntityFrameworkCore;

namespace HospiEnCasa.App.Persistencia
{   
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           if (!optionsBuilder.IsConfigured)
           {
               optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HospiEnCasaData");
           }
       }
   }
}using Microsoft.Empity

namespace HospiEnCasa.App.Persistencia
{
    public class AppContext : 
    {
    }
}
