using System.Collections.Generic;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public interface IRepositorioClsAdministrador
    {
        IEnumerable<ClsAdministrador> GetAllAdministradores();
        ClsAdministrador AddAdministrador(ClsAdministrador Administrador);
        ClsAdministrador UpdateAdministrador(ClsAdministrador Administrador);
        void DeleteAdministrador(int idAdministrador);
        ClsAdministrador GetAdministrador(int idAdministrador);
    }
}