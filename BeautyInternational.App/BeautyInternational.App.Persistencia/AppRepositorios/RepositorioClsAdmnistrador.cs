using System.Runtime.ExceptionServices;
using System.ComponentModel;
using System.Collections;
using System.Security.AccessControl;
using System;
using System.Linq;
using System.Collections.Generic;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public class RepositorioClsAdministrador:IRepositorioClsAdministrador{
        private readonly AppContext _appContext;
        public RepositorioClsAdministrador(AppContext appContext){
            _appContext=appContext;
        }

        ClsAdministrador IRepositorioClsAdministrador.AddAdministrador(ClsAdministrador administrador){
        var administradorAdicionado = _appContext.Administrador.Add(administrador);
        _appContext.SaveChanges();
        return administradorAdicionado.Entity;
        }

        void IRepositorioClsAdministrador.DeleteAdministrador(int idAdministrador){
            var administradorEncontrado = _appContext.Administrador.FirstOrDefault(p => p.id== idAdministrador);
            if(administradorEncontrado ==null)
                return;
            _appContext.Administrador.Remove(administradorEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<ClsAdministrador> IRepositorioClsAdministrador.GetAllAdministradores(){
            return _appContext.Administrador;
        }

        ClsAdministrador IRepositorioClsAdministrador.GetAdministrador(int idAdministrador){
            return _appContext.Administrador.FirstOrDefault(p => p.id== idAdministrador);
        }

        ClsAdministrador IRepositorioClsAdministrador.UpdateAdministrador(ClsAdministrador administrador){
            var administradorEncontrado = _appContext.Administrador.FirstOrDefault(p => p.id== administrador.id);
            if (administradorEncontrado!=null){
                administradorEncontrado.nombre = administrador.nombre;
                administradorEncontrado.apellido = administrador.apellido;
                administradorEncontrado.genero = administrador.genero;
                administradorEncontrado.celular = administrador.celular;
                administradorEncontrado.direccion = administrador.direccion;
                administradorEncontrado.fechaNacimiento = administrador.fechaNacimiento;
                administradorEncontrado.nivelEstudio = administrador.nivelEstudio;

                _appContext.SaveChanges();
            }
            return administradorEncontrado;
        }
    }
}