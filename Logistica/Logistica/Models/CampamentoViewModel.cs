using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Logistica.Models
{
    public class CampamentoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre del campamento es requerido")]
        [Display(Name ="Nombre del campamento")]
        public string Nombre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "La ubicación del campamento es requerido")]
        [Display(Name = "Provincia")]
        public string Provincia { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El comunidad del campamento es requerido")]
        [Display(Name = "Comunidad del campamento")]
        public string Comunidad { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "El tipo de baño del campamento es requerido")]
        [Display(Name = "Tipo de baño")]
        public string[] tipoBano { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "La ventilación del campamento es requerido")]
        [Display(Name = "Ventilación")]
        public string Ventilacion { get; set; }

        [Required(ErrorMessage = "La cantidad de baños del campamento es requerido")]
        [Range(0,10000,ErrorMessage ="No puede ingresar valores negativos o muy grandes")]
        [Display(Name = "Cantidad de baños")]
        public int CantidadBanos { get; set; }

        [Required(ErrorMessage = "La capacidad del campamento es requerido")]
        [Range(0,10000,ErrorMessage = "No puede ingresar valores negativos o muy grandes")]
        [Display(Name = "Capacidad del campamento")]
        public int Capacidad { get; set; }

        [Required(ErrorMessage = "La cantidad de habitaciones del campamento es requerido")]
        [Range(0,10000,ErrorMessage = "No puede ingresar valores negativos o muy grandes")]
        [Display(Name = "Habitaciones del campamento")]
        public int Habitaciones { get; set; }

        [Display(Name = "Agua potable")]
        public bool AguaPotable { get; set; }  

        public bool Electricidad { get; set; }

        public bool Wifi { get; set; }

        [Display(Name = "Señal de celular")]
        public bool SenalCelular { get; set; }        

        public List<SelectListItem> Provincias = new List<SelectListItem>()
        {
            new SelectListItem() {Text="Bocas del Toro", Value="1"},
            new SelectListItem() {Text="Coclé", Value="2"},
            new SelectListItem() {Text="Colón", Value="3"},
            new SelectListItem() {Text="Chiriquí", Value="4"},
            new SelectListItem() {Text="Darién", Value="5"},
            new SelectListItem() {Text="Herrera", Value="6"},
            new SelectListItem() {Text="Los Santos", Value="7"},
            new SelectListItem() {Text="Panamá", Value="8"},
            new SelectListItem() {Text="Panamá Oeste", Value="10"},
            new SelectListItem() {Text="Veraguas", Value="9"},
            new SelectListItem() {Text="San Blas", Value="11"}
        };

        public List<SelectListItem> TipoBanos = new List<SelectListItem>()
        {
            new SelectListItem() {Text="Letrina", Value="0"},
            new SelectListItem() { Text="Servicio comunal", Value="1"},
            new SelectListItem() { Text="Servicio individual", Value="2"},
        };

        public List<SelectListItem> Ventilaciones = new List<SelectListItem>()
        {
            new SelectListItem() {Text="Aire Acondicionado", Value="0"},
            new SelectListItem() { Text="Abanico", Value="1"},
            new SelectListItem() { Text="Ninguno", Value="2"},
        };
    }
}