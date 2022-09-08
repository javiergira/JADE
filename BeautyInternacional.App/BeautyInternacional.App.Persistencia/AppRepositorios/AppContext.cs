using Microsoft.EntityFrameworkCore;
using BeautyInternacional.App.Dominio;

namespace BeautyInternacional.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<ClsAdministrador> ClsAdministradores {get; set;}
        public DbSet<ClsCita> ClsCitas {get; set;}
        public DbSet<ClsCliente> ClsClientes {get; set;}
        //public DbSet<ClsGenero> ClsGeneros {get; set;}
        //public DbSet<ClsLogueo> ClsLogueos {get; set;}
        public DbSet<ClsPersona> ClsPersonas {get; set;}
        public DbSet<ClsProfesional> ClsProfesionales {get; set;}
        public DbSet<ClsServicio> ClsServicios {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BeautyInternacionalData");
        }
    }
    }
}