using System.Collections.Generic;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public interface IRepositorioClsPersona
    {
        IEnumerable<ClsPersona> GetAllPersonas();
        ClsPersona AddPersona(ClsPersona persona);
        ClsPersona UpdatePersona(ClsPersona persona);
        void DeletePersona(int idPersona);
        ClsPersona GetPersona(int idPersona);
    }
}