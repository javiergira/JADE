using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BeautyInternational.App.Dominio;
using BeautyInternational.App.Persistencia;

namespace BeautyInternational.App.Frontend.Pages
{
    public class RegistrosModel : PageModel
    {
        private readonly IRepositorioClsPersona repositorioClsPersona;

        [BindProperty]
        public ClsPersona persona {get;set;}

        public RegistrosModel(){
            this.repositorioClsPersona= new RepositorioClsPersona(new BeautyInternational.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? personaId)
        {
            if(personaId.HasValue){
                persona = repositorioClsPersona.GetPersona(personaId.Value);
            }
            else{
                persona = new ClsPersona();
            }
            if(persona==null){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }
        }

        public IActionResult OnPost(){
            if(!ModelState.IsValid){
                return Page();
            }
            if(persona.id>0){
                persona = repositorioClsPersona.UpdatePersona(persona);
            }
            else{
                persona = repositorioClsPersona.AddPersona(persona);
                return Page();
            }
            return Page();
        }
    }
}
