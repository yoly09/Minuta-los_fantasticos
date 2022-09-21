using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia.AppRepositorio;

namespace Minuta.App
{
    public class EditarModel : PageModel
    {
        //private static IRepositorioDatosUser _repoDatos; //= new RepositorioDatosUser(new Persistencia.AppRepositorio.AppContext());
        private readonly IRepositorioDatosUser repositorioDatosUser;
        [BindProperty]
        public DatosUser DatosUserDetalle{get;set;}
        public EditarModel(IRepositorioDatosUser repositorioDatosUser){
            this.repositorioDatosUser = repositorioDatosUser;
        }
        
        public IActionResult OnGet(int? ID)
        {
            if(ID.HasValue){
                DatosUserDetalle = repositorioDatosUser.GetLoginId(ID.Value);
            }else
                DatosUserDetalle= new DatosUser();

            if(DatosUserDetalle == null){
                return RedirectToPage("./Login");
            }else
                return Page();
        }
        public IActionResult OnPost(){
            if(!ModelState.IsValid){
                return Page();
            }
            if(DatosUserDetalle.Id > 0){
                DatosUserDetalle = repositorioDatosUser.Update(DatosUserDetalle);
            }else
                //repositorioDatosUser.Add(DatosUserDetalle);
                repositorioDatosUser.Add(DatosUserDetalle);
            
                return Page();
        }
    }
}
