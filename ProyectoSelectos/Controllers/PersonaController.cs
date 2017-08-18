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
    public class PersonaController : Controller
    {
        private ProyectoFinal db = new ProyectoFinal();

        // GET: Persona
        public ActionResult Index()
        {
            return View(db.Persona.ToList());
        }

        // GET: PersonaPorID
        public ActionResult Detalle(int? idPersona)
        {
            if (idPersona == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Persona.Find(idPersona);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // GET: Persona/Crear
        public ActionResult Crear()
        {
            return View();
        }

        // POST: Persona/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear([Bind(Include = "idPersona,nombre,apellidos,carnet,identificacion,tipo,EstadoArticulo,Permiso")] Persona Persona)
        {
            if (ModelState.IsValid)
            {
                db.Persona.Add(Persona);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Persona);
        }

        // GET: Persona/Modificar/5
        public ActionResult Modificar(int? idPersona)
        {
            if (idPersona == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Persona.Find(idPersona);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: Persona/Modificar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Modificar([Bind(Include = "idPersona,nombre,apellidos,carnet,identificacion,tipo,EstadoArticulo,Permiso")] Persona Persona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Persona).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Persona);
        }

        // GET: Persona/Eliminar/5
        public ActionResult Eliminar(int? idPersona)
        {
            if (idPersona == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           Persona persona = db.Persona.Find(idPersona);
            if (persona== null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: Persona/Eliminar/5
        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmarEliminar(int idPersona)
        {
            Persona persona = db.Persona.Find(idPersona);
            db.Articulo.Remove(persona);
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
