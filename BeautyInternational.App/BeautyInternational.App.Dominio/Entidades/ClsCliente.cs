using System;

namespace BeautyInternational.App.Dominio{
    public class ClsCliente : ClsPersona{
        public ClsCita cita {get;set;}
        public ClsHistoria historia {get;set;}
    }
}