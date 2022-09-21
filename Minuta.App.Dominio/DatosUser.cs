using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minuta.App.Dominio
{
    public class DatosUser
    {
        public int Id {get;set;}
        [Required(ErrorMessage ="Debes de escribir la Edad"), StringLength(50)]
        public string Edad {get;set;}
        public string Nombre {get;set;}
    }
}