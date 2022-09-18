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
    public class HistorialModel : PageModel
    {
        /*private readonly IRepositorioClsHistoria repositorioClsHistoria;

        public IEnumerable<ClsHistoria> Historias {get;set;}

        public HistorialModel(){
            this.repositorioClsHistoria= new repositorioClsHistoria(new BeautyInternational.App.Persistencia.AppContext());
        }*/

        public void OnGet()
        {
           /* Historias =repositorioClsHistoria.GetAllHistorias();*/
        }
    }
}
