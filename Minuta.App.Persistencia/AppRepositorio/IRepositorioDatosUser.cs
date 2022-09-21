using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia.AppRepositorio
{
    public interface IRepositorioDatosUser
    {
        IEnumerable<DatosUser> GetAll();
        DatosUser GetLoginId(int ID);
        DatosUser Update(DatosUser DatosUserEditar);
        DatosUser Add(DatosUser DatosUserAgregar);
        void DeleteDatos(int LoginID);
    }
}