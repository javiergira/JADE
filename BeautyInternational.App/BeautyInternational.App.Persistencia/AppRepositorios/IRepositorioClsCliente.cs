using System.Collections.Generic;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public interface IRepositorioClsCliente
    {
        IEnumerable<ClsCliente> GetAllClientes();
        ClsCliente AddClientes(ClsCliente cliente);
        ClsCliente UpdateCliente(ClsCliente cliente);
        void DeleteCliente(int idCliente);
        ClsCliente GetCliente(int idCliente);
    }
}