using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Logistica.Models
{
    public class RolesViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "El campo rol es requerido.")]
        [Display(Name = "Nombre del rol")]
        public string Name { get; set; }

    }
}