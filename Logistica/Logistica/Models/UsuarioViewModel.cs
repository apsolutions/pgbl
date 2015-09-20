using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Logistica.Models
{
    public class UsuarioViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "El campo usuario es requerido.")]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }
    }
}