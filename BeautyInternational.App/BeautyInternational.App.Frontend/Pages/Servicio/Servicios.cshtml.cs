using System.Globalization;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BeautyInternational.App.Dominio;
using BeautyInternational.App.Persistencia;

namespace BeautyInternational.App.Fronted.Pages
{
    public class ServiciosModel : PageModel
    {
        private readonly IRepositorioClsServicio repositorioClsServicio;

        public IEnumerable<ClsServicio> Servicios {get;set;}

        public ServiciosModel(){
            this.repositorioClsServicio= new RepositorioClsServicio(new BeautyInternational.App.Persistencia.AppContext());
        }

        public void OnGet()
        {
            Servicios =repositorioClsServicio.GetAllServicios();
        }
    }
}
