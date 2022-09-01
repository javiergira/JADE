using Microsoft.EntityFrameworkCore;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public class AppContext : DbContext{
        public DbSet<ClsPersona> Personas {get;set;}
        public DbSet<ClsCliente> Clientes {get;set;}
        public DbSet<ClsProfesional> Profesionales {get;set;}
        public DbSet<ClsAdministrador> Administrador {get;set;}
        public DbSet<ClsCita> Citas {get;set;}
        public DbSet<ClsServicio> Servicios {get;set;}
        public DbSet<ClsLogueo> Logueos {get;set;}
        public DbSet<ClsHistoria> Historias {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = localhost; user = sa; password = reallyStrongPwd123; Initial Catalog = BDT_BeautyInternational");
            }
        }
    }
}