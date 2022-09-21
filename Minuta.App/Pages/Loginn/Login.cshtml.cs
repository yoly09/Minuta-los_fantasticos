using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Persistencia.AppRepositorio;
using Minuta.App.Dominio;

namespace Minuta.App
{
    public class LoginModel : PageModel
    {
        //private static IRepositorioDatosUser _repoDatos; //= new RepositorioDatosUser(new Persistencia.AppRepositorio.AppContext());
        private readonly IRepositorioDatosUser repositorioDatosUser;
        public LoginModel(IRepositorioDatosUser repositorioDatosUser){
            this.repositorioDatosUser = repositorioDatosUser;
        }

        public IEnumerable<DatosUser> DatosUsser{get;set;}
            public void OnGet()
        {
            DatosUsser = repositorioDatosUser.GetAll();
            //DatosUsser = repositorioDatosUser.GetAll();
        }
    }
} 
