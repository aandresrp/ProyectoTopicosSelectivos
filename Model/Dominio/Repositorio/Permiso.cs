using Proyectos.Ulatina.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dominio.Repositorio
{
    internal class Permiso
    {
        private ProyectoFinalEntities _context = new ProyectoFinalEntities();
        //private DbContext elcontecto = new DbContext();



        public Permiso()
        {
        }

        internal IList<Proyectos.Ulatina.Model.Permiso> ListarTodos()
        {
            IList<Proyectos.Ulatina.Model.Permiso> resultado = _context.Permiso.ToList();
            return resultado;
        }

        internal void crearRegistro(Proyectos.Ulatina.Model.Permiso permiso)
        {
            _context.Permiso.Add(permiso);
        }

        internal void eliminarRegistro(int idDelaPersona, string Permiso)
        {
            _context.Permiso.Where();
        }


    }
}
