using System;

namespace BeautyInternacional.App.Dominio 
{
    public class ClsCita
    {
        public DateTime Fecha {get; set;}
        public DateTime Hora {get; set;}
        public string Servicio {get; set;}
        // Como se relacionan estos dos? Javier
        //Profesional : ClsProfesional
        //Cliente : ClsCliente
    }
}