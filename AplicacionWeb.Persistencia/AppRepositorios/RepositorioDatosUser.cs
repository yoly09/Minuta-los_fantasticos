using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicacionWeb.Dominio;

namespace AplicacionWeb.Persistencia.AppRepositorios
{
    public class RepositorioDatosUser : IRepositorioDatosUser
    {
        List<DatosUser> DatoUser;

        public RepositorioDatosUser()
        {
            DatoUser= new List<DatosUser>()
            {
                new DatosUser{Id=1, Edad="32", Nombre="Yefer"},
                new DatosUser{Id=2, Edad="20", Nombre="Andres"}
            };
        }

        public IEnumerable<DatosUser> GetAll()
        {
            return DatoUser;
        }
  
    }
}