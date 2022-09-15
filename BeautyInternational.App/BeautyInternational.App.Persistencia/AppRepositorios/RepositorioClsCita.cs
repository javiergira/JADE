using System.Runtime.ExceptionServices;
using System.ComponentModel;
using System.Collections;
using System.Security.AccessControl;
using System;
using System.Linq;
using System.Collections.Generic;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public class RepositorioClsCita:IRepositorioClsCita{
        private readonly AppContext _appContext;
        public RepositorioClsCita(AppContext appContext){
            _appContext=appContext;
        }

        ClsCita IRepositorioClsCita.AddCita(ClsCita cita){
        var citaAdicionada = _appContext.Citas.Add(cita);
        _appContext.SaveChanges();
        return citaAdicionada.Entity;
        }

        void IRepositorioClsCita.DeleteCita(int idCita){
            var citaEncontrada = _appContext.Citas.FirstOrDefault(p => p.id== idCita);
            if(citaEncontrada ==null)
                return;
            _appContext.Citas.Remove(citaEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<ClsCita> IRepositorioClsCita.GetAllCitas(){
            return _appContext.Citas;
        }

        ClsCita IRepositorioClsCita.GetCita(int idCita){
            return _appContext.Citas.FirstOrDefault(p => p.id== idCita);
        }

        ClsCita IRepositorioClsCita.UpdateCita(ClsCita cita){
            var citaEncontrada = _appContext.Citas.FirstOrDefault(p => p.id== cita.id);
            if (citaEncontrada!=null){
                citaEncontrada.fecha = cita.fecha;
                citaEncontrada.hora = cita.hora;
                citaEncontrada.servicio = cita.servicio;

                _appContext.SaveChanges();
            }
            return citaEncontrada;
        }
    }
}