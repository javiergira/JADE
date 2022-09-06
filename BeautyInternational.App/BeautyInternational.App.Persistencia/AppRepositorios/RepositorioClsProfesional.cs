using System.Runtime.ExceptionServices;
using System.ComponentModel;
using System.Collections;
using System.Security.AccessControl;
using System;
using System.Linq;
using System.Collections.Generic;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public class RepositorioClsProfesional:IRepositorioClsProfesional{
        private readonly AppContext _appContext;
        public RepositorioClsProfesional(AppContext appContext){
            _appContext=appContext;
        }

        ClsProfesional IRepositorioClsProfesional.AddProfesional(ClsProfesional profesional){
        var profesionalAdicionado = _appContext.Profesionales.Add(profesional);
        _appContext.SaveChanges();
        return profesionalAdicionado.Entity;
        }

        void IRepositorioClsProfesional.DeleteProfesional (int idProfesional){
            var profesionalEncontrado = _appContext.Profesionales.FirstOrDefault(p => p.id== idProfesional);
            if(profesionalEncontrado ==null)
                return;
            _appContext.Profesionales.Remove(profesionalEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<ClsProfesional> IRepositorioClsProfesional.GetAllProfesionales(){
            return _appContext.Profesionales;
        }

        ClsProfesional IRepositorioClsProfesional.GetProfesional(int idProfesional){
            return _appContext.Profesionales.FirstOrDefault(p => p.id== idProfesional);
        }

        ClsProfesional IRepositorioClsProfesional.UpdateProfesional (ClsProfesional profesional){
            var profesionalEncontrado = _appContext.Profesionales.FirstOrDefault(p => p.id== profesional.id);
            if (profesionalEncontrado!=null){
                profesionalEncontrado.nombre = profesional.nombre;
                profesionalEncontrado.apellido = profesional.apellido;
                profesionalEncontrado.genero = profesional.genero;
                profesionalEncontrado.celular = profesional.celular;
                profesionalEncontrado.direccion = profesional.direccion;
                profesionalEncontrado.fechaNacimiento = profesional.fechaNacimiento;
                profesionalEncontrado.nivelEstudio = profesional.nivelEstudio;

                _appContext.SaveChanges();
            }
            return profesionalEncontrado;
        }
    }
}