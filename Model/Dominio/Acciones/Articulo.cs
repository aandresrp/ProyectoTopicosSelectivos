using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Ulatina.BL.Dominio.Acciones
{
    public class Articulo
    {
        public IList<Proyectos.Ulatina.Model.Articulo> ListarTodos()
        {
            IList<Proyectos.Ulatina.Model.Articulo> resultado;
            var especificacion = new Dominio.Especificaciones.Articulo();
            resultado = especificacion.ListarTodos();
            return resultado;
        }
    }
}
