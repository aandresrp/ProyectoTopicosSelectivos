using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using System.Data;
using ProyectoSelectos.Models;

namespace ProyectoSelectos.Controllers
{
    public class ArticuloController : Controller
    {
        private ProyectoFinal db = new ProyectoFinal();

        // GET: Articulo
        public ActionResult Index()
        {
            return View(db.Articulo.ToList());
        }

        // GET: ArticuloPorID
        public ActionResult Detalle(int? idArticulo)
        {
            if (idArticulo == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Articulo articulo = db.Articulo.Find(idArticulo);
            if (articulo== null)
            {
                return HttpNotFound();
            }
            return View(articulo);
        }

        // GET: Articulo/Crear
        public ActionResult Crear()
        {
            return View();
        }

        // POST: Articulo/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear([Bind(Include = "idArticulo,nombre,color,EstadoArticulo")] Articulo Articulo)
        {
            if (ModelState.IsValid)
            {
                db.Articulos.Add(Articulo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Articulo);
        }

        // GET: Articulo/Modificar/5
        public ActionResult Modificar(int? idArticulo)
        {
            if (idArticulo == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Articulo articulo = db.Articulo.Find(idArticulo);
            if (articulo == null)
            {
                return HttpNotFound();
            }
            return View(articulo);
        }

        // POST: Articulo/Modificar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Modificar([Bind(Include = "idArticulo,nombre,color,EstadoArticulo")] Articulo Articulo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Articulo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Articulo);
        }

        // GET: Articulo/Eliminar/5
        public ActionResult Eliminar(int? idArticulo)
        {
            if (idArticulo == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Articulo articulo = db.Articulo.Find(idArticulo);
            if (articulo == null)
            {
                return HttpNotFound();
            }
            return View(articulo);
        }

        // POST: Articulo/Eliminar/5
        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmarEliminar(int idArticulo)
        {
            Articulo articulo = db.Articulo.Find(idArticulo);
            db.Articulo.Remove(articulo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}
