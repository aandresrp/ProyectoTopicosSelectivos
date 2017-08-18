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
    public class EstadoArticuloController : Controller
    {
        private ProyectoFinal db = new ProyectoFinal();

        // GET: EstadoArticulo
        public ActionResult Index()
        {
            return View(db.EstadoArticulo.ToList());
        }

        // GET: EstadoArticuloPorID
        public ActionResult Detalle(int? idArticulo, int? idPersona)
        {
            if (idArticulo == null || idPersona ==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoArticulo estadoArticulo = db.EstadoArticulo.Find(idArticulo,idPersona);
            if (estadoArticulo == null)
            {
                return HttpNotFound();
            }
            return View(estadoArticulo);
        }

        // GET: EstadoArticulo/Crear
        public ActionResult Crear()
        {
            return View();
        }

        // POST: EstadoArticulo/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear([Bind(Include = "idArticulo, idPersona, fecha, descripcion,estado")] EstadoArticulo EstadoArticulo)
        {
            if (ModelState.IsValid)
            {
                db.EstadoArticulo.Add(EstadoArticulo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(EstadoArticulo);
        }

        // GET: EstadoArticulo/Modificar/5
        public ActionResult Modificar(int? idArticulo, int? idPersona)
        {
            if (idArticulo == null || idPersona == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoArticulo estadoArticulo = db.EstadoArticulo.Find(idArticulo,idPersona);
            if (estadoArticulo == null)
            {
                return HttpNotFound();
            }
            return View(estadoArticulo);
        }

        // POST: EstadoArticulo/Modificar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Modificar([Bind(Include = "idArticulo, idPersona, fecha, descripcion,estado")] EstadoArticulo EstadoArticulo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(EstadoArticulo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(EstadoArticulo);
        }

        // GET: EstadoArticulo/Eliminar/5
        public ActionResult Eliminar(int? idArticulo, int? idPersona)
        {
            if (idArticulo == null || idPersona ==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoArticulo estadoArticulo = db.EstadoArticulo.Find(idArticulo, idPersona);
            if (estadoArticulo == null)
            {
                return HttpNotFound();
            }
            return View(estadoArticulo);
        }

        // POST: EstadoArticulo/Eliminar/5
        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmarEliminar(int idArticulo, int idPersona)
        {
            EstadoArticulo estadoArticulo = db.EstadoArticulo.Find(idArticulo, idPersona);
            db.EstadoArticulo.Remove(estadoArticulo);
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
