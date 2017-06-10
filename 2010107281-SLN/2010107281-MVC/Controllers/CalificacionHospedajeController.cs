using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2010107281_ENT.Entities;
using _2010107281_PER;

namespace _2010107281_MVC.Controllers
{
    public class CalificacionHospedajeController : Controller
    {
        private PaqueteTuristicoContext db = new PaqueteTuristicoContext();

        // GET: CalificacionHospedaje
        public ActionResult Index()
        {
            var calificacionHospedajes = db.CalificacionHospedajes.Include(c => c.Hospedaje);
            return View(calificacionHospedajes.ToList());
        }

        // GET: CalificacionHospedaje/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalificacionHospedaje calificacionHospedaje = db.CalificacionHospedajes.Find(id);
            if (calificacionHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(calificacionHospedaje);
        }

        // GET: CalificacionHospedaje/Create
        public ActionResult Create()
        {
            ViewBag.CalificacionHospedajeId = new SelectList(db.ServiciosTuristicos, "ServicioTuristicoId", "Fecha");
            return View();
        }

        // POST: CalificacionHospedaje/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CalificacionHospedajeId,HospedajeId")] CalificacionHospedaje calificacionHospedaje)
        {
            if (ModelState.IsValid)
            {
                db.CalificacionHospedajes.Add(calificacionHospedaje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CalificacionHospedajeId = new SelectList(db.ServiciosTuristicos, "ServicioTuristicoId", "Fecha", calificacionHospedaje.CalificacionHospedajeId);
            return View(calificacionHospedaje);
        }

        // GET: CalificacionHospedaje/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalificacionHospedaje calificacionHospedaje = db.CalificacionHospedajes.Find(id);
            if (calificacionHospedaje == null)
            {
                return HttpNotFound();
            }
            ViewBag.CalificacionHospedajeId = new SelectList(db.ServiciosTuristicos, "ServicioTuristicoId", "Fecha", calificacionHospedaje.CalificacionHospedajeId);
            return View(calificacionHospedaje);
        }

        // POST: CalificacionHospedaje/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CalificacionHospedajeId,HospedajeId")] CalificacionHospedaje calificacionHospedaje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calificacionHospedaje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CalificacionHospedajeId = new SelectList(db.ServiciosTuristicos, "ServicioTuristicoId", "Fecha", calificacionHospedaje.CalificacionHospedajeId);
            return View(calificacionHospedaje);
        }

        // GET: CalificacionHospedaje/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalificacionHospedaje calificacionHospedaje = db.CalificacionHospedajes.Find(id);
            if (calificacionHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(calificacionHospedaje);
        }

        // POST: CalificacionHospedaje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CalificacionHospedaje calificacionHospedaje = db.CalificacionHospedajes.Find(id);
            db.CalificacionHospedajes.Remove(calificacionHospedaje);
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
