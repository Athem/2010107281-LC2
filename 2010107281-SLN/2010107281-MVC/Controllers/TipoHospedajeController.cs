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
    public class TipoHospedajeController : Controller
    {
        private PaqueteTuristicoContext db = new PaqueteTuristicoContext();

        // GET: TipoHospedaje
        public ActionResult Index()
        {
            var tiposHospedaje = db.TiposHospedaje.Include(t => t.Hospedaje);
            return View(tiposHospedaje.ToList());
        }

        // GET: TipoHospedaje/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoHospedaje tipoHospedaje = db.TiposHospedaje.Find(id);
            if (tipoHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(tipoHospedaje);
        }

        // GET: TipoHospedaje/Create
        public ActionResult Create()
        {
            ViewBag.TipoHospedajeId = new SelectList(db.ServiciosTuristicos, "ServicioTuristicoId", "Fecha");
            return View();
        }

        // POST: TipoHospedaje/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoHospedajeId,HospedajeId")] TipoHospedaje tipoHospedaje)
        {
            if (ModelState.IsValid)
            {
                db.TiposHospedaje.Add(tipoHospedaje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TipoHospedajeId = new SelectList(db.ServiciosTuristicos, "ServicioTuristicoId", "Fecha", tipoHospedaje.TipoHospedajeId);
            return View(tipoHospedaje);
        }

        // GET: TipoHospedaje/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoHospedaje tipoHospedaje = db.TiposHospedaje.Find(id);
            if (tipoHospedaje == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipoHospedajeId = new SelectList(db.ServiciosTuristicos, "ServicioTuristicoId", "Fecha", tipoHospedaje.TipoHospedajeId);
            return View(tipoHospedaje);
        }

        // POST: TipoHospedaje/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoHospedajeId,HospedajeId")] TipoHospedaje tipoHospedaje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoHospedaje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TipoHospedajeId = new SelectList(db.ServiciosTuristicos, "ServicioTuristicoId", "Fecha", tipoHospedaje.TipoHospedajeId);
            return View(tipoHospedaje);
        }

        // GET: TipoHospedaje/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoHospedaje tipoHospedaje = db.TiposHospedaje.Find(id);
            if (tipoHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(tipoHospedaje);
        }

        // POST: TipoHospedaje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoHospedaje tipoHospedaje = db.TiposHospedaje.Find(id);
            db.TiposHospedaje.Remove(tipoHospedaje);
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
