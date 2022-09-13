using System.ComponentModel;
using System.Globalization;
using System.Collections;
using System.Runtime.InteropServices.WindowsRuntime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using AplicacionWeb.Persistencia.AppRepositorios;
using AplicacionWeb.Dominio;

namespace Frontend.Pages
{
    public class UserDataModel : PageModel
    {

        //private string[] datos = { "12", "yefer" };
        
        //public List<string> ListaDatos { get; set; }

        private IRepositorioDatosUser repositorioDatosUser;

        public IEnumerable<DatosUser> DatoUser {get;set;}

        public UserDataModel(IRepositorioDatosUser repositorioDatosUser)
        {
            this.repositorioDatosUser=repositorioDatosUser;
        }

        public void OnGet()
        {
            //ListaDatos = new List<string>();
            //ListaDatos.AddRange(datos);
            DatoUser=repositorioDatosUser.GetAll();
        }
    }
}
