using System.Collections.Generic;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public interface IRepositorioClsHistoria
    {
        IEnumerable<ClsHistoria> GetAllHistorias();
        ClsHistoria AddHistoria(ClsHistoria Historia);
        ClsHistoria UpdateHistoria(ClsHistoria Historia);
        void DeleteHistoria(int idHistoria);
        ClsHistoria GetHistoria(int idHistoria);
    }
}