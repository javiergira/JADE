using System.Runtime.ExceptionServices;
using System.ComponentModel;
using System.Collections;
using System.Security.AccessControl;
using System;
using System.Linq;
using System.Collections.Generic;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public class RepositorioClsLogueo:IRepositorioClsLogueo{
        private readonly AppContext _appContext;
        public RepositorioClsLogueo(AppContext appContext){
            _appContext=appContext;
        }

        ClsLogueo IRepositorioClsLogueo.AddLogueo(ClsLogueo loggin){
        var logginAdicionado = _appContext.Logueos.Add(loggin);
        _appContext.SaveChanges();
        return logginAdicionado.Entity;
        }

        void IRepositorioClsLogueo.DeleteLogueo(int idLoggin){
            var logginEncontrado = _appContext.Logueos.FirstOrDefault(p => p.id== idLoggin);
            if(logginEncontrado ==null)
                return;
            _appContext.Logueos.Remove(logginEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<ClsLogueo> IRepositorioClsLogueo.GetAllLogueos(){
            return _appContext.Logueos;
        }

        ClsLogueo IRepositorioClsLogueo.GetLogueo(int idLoggin){
            return _appContext.Logueos.FirstOrDefault(p => p.id== idLoggin);
        }

        ClsLogueo IRepositorioClsLogueo.UpdateLogueo (ClsLogueo loggin){
            var logginEncontrado = _appContext.Logueos.FirstOrDefault(p => p.id== loggin.id);
            if (logginEncontrado!=null){
                logginEncontrado.usuario = loggin.usuario;
                logginEncontrado.contrasena = loggin.contrasena;

                _appContext.SaveChanges();
            }
            return logginEncontrado;
        }
    }
}