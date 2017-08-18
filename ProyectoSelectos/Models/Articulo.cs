using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProyectoSelectos.Models
{
    public class Articulo
    {
        [Display(Name = "ID")]
        [Required(ErrorMessage = "El ID es requerido")]
        public int idArticulo { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string nombre { get; set; }

        [Display(Name = "Color")]
        [Required(ErrorMessage = "El color es requerido")]
        public string color { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "La descripción es requerida")]
        public int descripcion { get; set; }
    }

}