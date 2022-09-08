using System;

namespace BeautyInternational.App.Dominio{
    public class ClsCita{
        public DateTime fecha {get;set;}
        public DateTime hora {get;set;}
        public ClsServicio servicio {get;set;}
        public int id {get;set;}
    }
}