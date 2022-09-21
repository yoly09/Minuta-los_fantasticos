using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Persistencia.AppRepositorio;
using Minuta.App.Dominio;

namespace Minuta.App
{
    
    public class DetalleModel : PageModel
    {
        private static IRepositorioDatosUser _repoDatos; //= new RepositorioDatosUser(new Persistencia.AppRepositorio.AppContext());

        public DatosUser DatosUserDetalle{get;set;}
        private readonly IRepositorioDatosUser repositorioDatosUser;
        public DetalleModel(IRepositorioDatosUser repositorioDatosUser){
            this.repositorioDatosUser = repositorioDatosUser;

        }
        public IActionResult OnGet(int LoginID)
        {
            DatosUserDetalle = _repoDatos.GetLoginId(LoginID);
            //DatosUserDetalle = repositorioDatosUser.GetLoginId(LoginID);
            if(DatosUserDetalle == null){
                return RedirectToPage("./Login");
            }else
                return Page();
        }
        }
        //private readonly IRepositorioDatosUser repositorioDatosUser;
        

        
        /*public DetalleModel(IRepositorioDatosUser repositorioDatosUser){
            this.repositorioDatosUser = repositorioDatosUser;
        }*/
}
