using System.Collections.Generic;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public interface IRepositorioClsServicio
    {
        IEnumerable<ClsServicio> GetAllServicios();
        ClsServicio AddServicio(ClsServicio servicio);
        ClsServicio UpdateServicio(ClsServicio servicio);
        void DeleteServicio(int idServicio);
        ClsServicio GetServicio(int idServicio);
    }
}