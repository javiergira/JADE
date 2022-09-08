using System;

namespace BeautyInternacional.App.Dominio
{
    public class ClsPersona
    {
        public string RegistroUnico {get; set;}
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public Genero Genero {get; set;}
        public string NumeroCelular {get; set;}
        public string CorreoElectronico {get; set;}
        public string Direccion {get; set;}
        public DateTime Fecha {get; set;} 
 
    }
    
    
}