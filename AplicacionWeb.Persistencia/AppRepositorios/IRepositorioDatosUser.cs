using System;
using System.Collections.Generic;
using AplicacionWeb.Dominio;

namespace AplicacionWeb.Persistencia.AppRepositorios
{
    public interface IRepositorioDatosUser
    {
        IEnumerable<DatosUser> GetAll();   
    }
}