using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Ulatina.BL.Dominio.Especificaciones
{
    public class Articulo
    {
        public IList<Proyectos.Ulatina.Model.Articulo> ListarTodos()
        {
            IList<Proyectos.Ulatina.Model.Articulo> resultado;
            var repositorio = new Dominio.Repositorio.Articulo();
            resultado = repositorio.ListarTodos();
            return resultado;
        }
    }


}
