using System.Collections.Generic;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public interface IRepositorioClsLogueo
    {
        IEnumerable<ClsLogueo> GetAllLogueos();
        ClsLogueo AddLogueo(ClsLogueo Logueo);
        ClsLogueo UpdateLogueo(ClsLogueo Logueo);
        void DeleteLogueo(int idLogueo);
        ClsLogueo GetLogueo(int idLogueo);
    }
}