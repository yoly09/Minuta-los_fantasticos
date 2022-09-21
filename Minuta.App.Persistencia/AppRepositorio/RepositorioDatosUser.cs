using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia.AppRepositorio
{
    public class RepositorioDatosUser : IRepositorioDatosUser
    {
        //Base de datos//
        private AppContext appContext = new AppContext();
        /*private Minuta.App.Persistencia.AppRepositorio.AppContext appContext;

        public RepositorioDatosUser(AppContext appContext)
        {
            this.appContext = appContext;
        }*/

        //Constructor//
        /*public RepositorioDatosUser(AppContext appContext){
            appcox = appContext;
        }*/
        /////////////////
        /*(List<DatosUser> DatosUsser;
        public RepositorioDatosUser(){
            DatosUsser = new List<DatosUser>{
                new DatosUser{Id=123, Edad=17, Nombre="Brayan"},
                new DatosUser{Id=345, Edad=16, Nombre="Natalia"},
                new DatosUser{Id=567, Edad=20, Nombre="Genny"},
                new DatosUser{Id=890, Edad=35, Nombre="Geovanny"},
                new DatosUser{Id=098, Edad=30, Nombre="Fredy"}
            }
        }*/

        public DatosUser Add(DatosUser DatosUserAgregar)
        {
            var AgregarDatos = appContext.DatosUsersDB.Add(DatosUserAgregar);
            appContext.SaveChanges();
            return AgregarDatos.Entity;
            /*DatosUserAgregar.Id = DatosUsser.Max(r => r.Id)+1;
            DatosUsser.Add(DatosUserAgregar);
            return DatosUserAgregar;*/
        }

        public IEnumerable<DatosUser> GetAll()
        {
            return appContext.DatosUsersDB;
            //return DatosUsser;
        }

        public DatosUser GetLoginId(int LoginID)
        {
            return appContext.DatosUsersDB.SingleOrDefault(a => a.Id == LoginID);
            //return DatosUsser.SingleOrDefault(a => a.Id == ID);
        }

        public DatosUser Update(DatosUser DatosUserEditar)
        {
            var Datico = appContext.DatosUsersDB.SingleOrDefault(s => s.Id == DatosUserEditar.Id);

            //var Datico = DatosUsser.SingleOrDefault(s => s.Id == DatosUserEditar.Id);

            if(Datico != null){
                Datico.Nombre = DatosUserEditar.Nombre;
                Datico.Edad = DatosUserEditar.Edad;
            }
            return Datico;
        }

        public void DeleteDatos(int LoginID)
        {
            var DatoUserEncontrado = appContext.DatosUsersDB.FirstOrDefault(d => d.Id == LoginID);
            if(DatoUserEncontrado == null){
                return;
            }
            appContext.DatosUsersDB.Remove(DatoUserEncontrado);
            appContext.SaveChanges();
        }
    }
}