using System.Runtime.ExceptionServices;
using System.ComponentModel;
using System.Collections;
using System.Security.AccessControl;
using System;
using System.Linq;
using System.Collections.Generic;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public class RepositorioClsServicio:IRepositorioClsServicio{
        private readonly AppContext _appContext;
        public RepositorioClsServicio(AppContext appContext){
            _appContext=appContext;
        }

        ClsServicio IRepositorioClsServicio.AddServicio (ClsServicio servicio){
        var servicioAdicionado = _appContext.Servicios.Add(servicio);
        _appContext.SaveChanges();
        return servicioAdicionado.Entity;
        }

        void IRepositorioClsServicio.DeleteServicio(int idServicio){
            var servicioEncontrado = _appContext.Servicios.FirstOrDefault(p => p.id== idServicio);
            if(servicioEncontrado ==null)
                return;
            _appContext.Servicios.Remove(servicioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<ClsServicio> IRepositorioClsServicio.GetAllServicios(){
            return _appContext.Servicios;
        }

        ClsServicio IRepositorioClsServicio.GetServicio(int idServicio){
            return _appContext.Servicios.FirstOrDefault(p => p.id== idServicio);
        }

        ClsServicio IRepositorioClsServicio.UpdateServicio (ClsServicio servicio){
            var servicioEncontrado = _appContext.Servicios.FirstOrDefault(p => p.id== servicio.id);
            if (servicioEncontrado!=null){
                servicioEncontrado.tipoServicio = servicio.tipoServicio;
                servicioEncontrado.precio = servicio.precio;

                _appContext.SaveChanges();
            }
            return servicioEncontrado;
        }
    }
}