using System;
using BeautyInternational.App.Dominio;
using BeautyInternational.App.Persistencia;

namespace BeautyInternational.App.Consola
{
    class Program
    {
        private static IRepositorioClsPersona _repoPersona = new RepositorioClsPersona(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddPersona();
        }

        private static void AddPersona(){
            var persona = new ClsPersona{
                registroUnico = "0001",
                nombre = "Nicolay",
                apellido = "Perez",
                genero = "Hombre",
                celular = "3208456570",
                correo = "nicolindo@hotmail.com",
                direccion = "Carre54 #63-22 sur",
                fechaNacimiento = new DateTime(1999, 12, 04)
            };
            _repoPersona.AddPersona(persona);
        }
    }
}
