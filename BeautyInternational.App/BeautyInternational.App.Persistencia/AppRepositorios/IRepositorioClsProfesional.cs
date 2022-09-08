using System.Collections.Generic;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public interface IRepositorioClsProfesional
    {
        IEnumerable<ClsProfesional> GetAllProfesionales();
        ClsProfesional AddProfesional(ClsProfesional Profesional);
        ClsProfesional UpdateProfesional(ClsProfesional Profesional);
        void DeleteProfesional(int idProfesional);
        ClsProfesional GetProfesional(int idProfesional);
    }
}