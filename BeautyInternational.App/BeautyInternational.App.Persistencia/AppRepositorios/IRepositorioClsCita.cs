using System.Collections.Generic;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public interface IRepositorioClsCita
    {
        IEnumerable<ClsCita> GetAllCitas();
        ClsCita AddCita(ClsCita Cita);
        ClsCita UpdateCita(ClsCita Cita);
        void DeleteCita(int idCita);
        ClsCita GetCita(int idCita);
    }
}