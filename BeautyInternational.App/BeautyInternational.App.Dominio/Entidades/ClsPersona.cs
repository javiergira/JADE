using System;

namespace BeautyInternational.App.Dominio{
    public class ClsPersona{
        public string registroUnico {get;set;}
        public int id {get;set;}
        public string nombre {get;set;}
        public string apellido {get;set;}
        public string genero {get;set;}
        public string celular {get;set;}
        public string correo {get;set;}
        public string direccion {get;set;}
        public DateTime fechaNacimiento {get;set;}
    }
}