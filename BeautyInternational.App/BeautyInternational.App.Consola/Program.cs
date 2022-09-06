using System;
using BeautyInternational.App.Dominio;
using BeautyInternational.App.Persistencia;

namespace BeautyInternational.App.Consola
{
    class Program
    {
        private static IRepositorioClsServicio _repoServicio = new RepositorioClsServicio(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BorrarServicio(1);
            //crearServicio();
        }

        /*private static void crearServicio(){
            var servicio = new ClsServicio{
                tipoServicio = "Corte cabello",
                precio = 15000
            };
            _repoServicio.AddServicio(servicio);
        }*/

        private static void BorrarServicio(int idServicio){
            _repoServicio.DeleteServicio(idServicio);
            }
        }
        }
