using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProyectoSelectos.Models
{
    public class Persona
    {
        [Display(Name = "ID")]
        [Required(ErrorMessage = "El ID es requerido")]
        public int idPersona { get; set; } 

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string nombre { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "El apellido es requerido")]
        public string apellidos { get; set; }

        [Display(Name = "carnet")]
        [Required(ErrorMessage = "El carnet es requerido")]
        public int carnet { get; set; }

        [Display(Name = "Identificación")]
        [Required(ErrorMessage = "La identificacion es requerido")]
        public int identificacion { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "El tipo es requerido")]
        public int tipo { get; set; }
    }



}