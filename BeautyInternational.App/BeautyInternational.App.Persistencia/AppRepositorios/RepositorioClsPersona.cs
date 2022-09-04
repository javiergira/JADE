using System.Runtime.ExceptionServices;
using System.ComponentModel;
using System.Collections;
using System.Security.AccessControl;
using System;
using System.Linq;
using System.Collections.Generic;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public class RepositorioClsPersona : IRepositorioClsPersona{
        private readonly AppContext _appContext;
        public RepositorioClsPersona(AppContext appContext){
            _appContext=appContext;
        }

        ClsPersona IRepositorioClsPersona.AddPersona(ClsPersona persona){
        var personaAdicionado = _appContext.Personas.Add(persona);
        _appContext.SaveChanges();
        return personaAdicionado.Entity;
        }

        void IRepositorioClsPersona.DeletePersona(int idPersona){
            var personaEncontrado = _appContext.Personas.FirstOrDefault(p => p.id== idPersona);
            if(personaEncontrado==null)
                return;
            _appContext.Personas.Remove(personaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<ClsPersona> IRepositorioClsPersona.GetAllPersonas(){
            return _appContext.Personas;
        }

        ClsPersona IRepositorioClsPersona.GetPersona(int idPersona){
            return _appContext.Personas.FirstOrDefault(p => p.id== idPersona);
        }

        ClsPersona IRepositorioClsPersona.UpdatePersona(ClsPersona persona){
            var personaEncontrado = _appContext.Personas.FirstOrDefault(p => p.id== persona.id);
            if (personaEncontrado!=null){
                personaEncontrado.nombre = persona.nombre;
                personaEncontrado.apellido = persona.apellido;
                personaEncontrado.genero = persona.genero;
                personaEncontrado.celular = persona.celular;
                personaEncontrado.direccion = persona.direccion;
                personaEncontrado.fechaNacimiento = persona.fechaNacimiento;

                _appContext.SaveChanges();
            }
            return personaEncontrado;
        }
    }
}