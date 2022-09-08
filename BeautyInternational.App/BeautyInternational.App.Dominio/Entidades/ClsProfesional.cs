using System;

namespace BeautyInternational.App.Dominio{
    public class ClsProfesional: ClsPersona{
        public string nivelEstudio {get;set;}
        public ClsCita cita {get;set;}
    }
}