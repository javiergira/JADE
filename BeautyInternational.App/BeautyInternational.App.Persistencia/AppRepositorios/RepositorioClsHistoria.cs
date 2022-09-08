using System.Runtime.ExceptionServices;
using System.ComponentModel;
using System.Collections;
using System.Security.AccessControl;
using System;
using System.Linq;
using System.Collections.Generic;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public class RepositorioClsHistoria: IRepositorioClsHistoria{
        private readonly AppContext _appContext;
        public RepositorioClsHistoria(AppContext appContext){
            _appContext=appContext;
        }

        ClsHistoria IRepositorioClsHistoria.AddHistoria(ClsHistoria historia){
        var historiaAdicionada = _appContext.Historias.Add(historia);
        _appContext.SaveChanges();
        return historiaAdicionada.Entity;
        }

        void IRepositorioClsHistoria.DeleteHistoria(int idHistoria){
            var historiaEncontrado = _appContext.Historias.FirstOrDefault(p => p.id== idHistoria);
            if(historiaEncontrado ==null)
                return;
            _appContext.Historias.Remove(historiaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<ClsHistoria> IRepositorioClsHistoria.GetAllHistorias(){
            return _appContext.Historias;
        }

        ClsHistoria IRepositorioClsHistoria.GetHistoria(int idHistoria){
            return _appContext.Historias.FirstOrDefault(p => p.id== idHistoria);
        }

        ClsHistoria IRepositorioClsHistoria.UpdateHistoria (ClsHistoria historia){
            var historiaEncontrado = _appContext.Historias.FirstOrDefault(p => p.id== historia.id);
            if (historiaEncontrado!=null){
                historiaEncontrado.citas = historia.citas;

                _appContext.SaveChanges();
            }
            return historiaEncontrado;
        }
    }
}