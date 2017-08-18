using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProyectoSelectos.Models
{
    public class EstadoArticulo
    {
        [Display(Name = "ID Articulo")]
        [Required(ErrorMessage = "El ID Articulo es requerido")]
        public int idArticulo { get; set; }

        [Display(Name = "ID Persona")]
        [Required(ErrorMessage = "El ID Persona es requerido")]
        public int idPersona { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "La fecha es requerida")]
        public string fecha { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "La descripción es requerida")]
        public string descripcion { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "El estado es requerido")]
        public int estado { get; set; }
    }

    public class ProyectoDBContext : DbContext
    {
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<EstadoArticulo> EstadoArticulo { get; set; }
    }
}