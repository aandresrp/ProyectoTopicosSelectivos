//using ProyectoSelectos.GenericRepository;
using Proyectos.Ulatina.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Ulatina.Topicos.GenericRepository;

namespace Proyecto.Ulatina.BL.Dominio.Repositorio
{
    internal class Articulo
    {
        
        private ProyectoFinalEntities _context = new ProyectoFinalEntities();
        //private DbContext elcontecto = new DbContext();
            


        public Articulo()
        {
        }

        internal IList<Proyectos.Ulatina.Model.Articulo> ListarTodos()
        {
            IList<Proyectos.Ulatina.Model.Articulo> resultado = _context.Articulo.ToList();
                return resultado;
        }

        internal void agregarArticulo(string nombre, string color, string descripcion)
        {
            Proyectos.Ulatina.Model.Articulo articuloNuevo = new Proyectos.Ulatina.Model.Articulo();
            articuloNuevo.nombre = nombre;
            articuloNuevo.color = color;
            articuloNuevo.descripcion = descripcion;

            _context.Articulo.Add(articuloNuevo);
            _context.SaveChanges();

        }


        internal Proyectos.Ulatina.Model.Articulo ConsultaProductosPorNumero(int miNumeroDeArticulo)
        {
            Proyectos.Ulatina.Model.Articulo elArticulo = _context.Articulo.Find(miNumeroDeArticulo);
            return elArticulo;
        }

        internal IList<Proyectos.Ulatina.Model.Articulo> ConsultaArticuloPorNombre(string nombreDelProducto)
        {
            IList<Proyectos.Ulatina.Model.Articulo> elArticulo = _context.Articulo.Where<Proyectos.Ulatina.Model.Articulo>(p => p.nombre.Contains(nombreDelProducto)).ToList();
            return elArticulo;
        }

        internal void borrarArticulo(int numeroArticuloABorrar)
        {
            Proyectos.Ulatina.Model.Articulo articulo = new Articulo()._context.Articulo.Find(numeroArticuloABorrar);

            _context.Articulo.Remove(articulo);
            _context.SaveChanges();

        }


    }
}
