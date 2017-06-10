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
    public class TipoComprobanteController : Controller
    {
        private PaqueteTuristicoContext db = new PaqueteTuristicoContext();

        // GET: TipoComprobante
        public ActionResult Index()
        {
            var tiposComprobante = db.TiposComprobante.Include(t => t.ComprobantePago);
            return View(tiposComprobante.ToList());
        }

        // GET: TipoComprobante/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoComprobante tipoComprobante = db.TiposComprobante.Find(id);
            if (tipoComprobante == null)
            {
                return HttpNotFound();
            }
            return View(tipoComprobante);
        }

        // GET: TipoComprobante/Create
        public ActionResult Create()
        {
            ViewBag.ComprobantePagoId = new SelectList(db.ComprobantesPago, "ComprobantePagoId", "ComprobantePagoId");
            return View();
        }

        // POST: TipoComprobante/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoComprobanteId,ComprobantePagoId")] TipoComprobante tipoComprobante)
        {
            if (ModelState.IsValid)
            {
                db.TiposComprobante.Add(tipoComprobante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ComprobantePagoId = new SelectList(db.ComprobantesPago, "ComprobantePagoId", "ComprobantePagoId", tipoComprobante.ComprobantePagoId);
            return View(tipoComprobante);
        }

        // GET: TipoComprobante/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoComprobante tipoComprobante = db.TiposComprobante.Find(id);
            if (tipoComprobante == null)
            {
                return HttpNotFound();
            }
            ViewBag.ComprobantePagoId = new SelectList(db.ComprobantesPago, "ComprobantePagoId", "ComprobantePagoId", tipoComprobante.ComprobantePagoId);
            return View(tipoComprobante);
        }

        // POST: TipoComprobante/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoComprobanteId,ComprobantePagoId")] TipoComprobante tipoComprobante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoComprobante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ComprobantePagoId = new SelectList(db.ComprobantesPago, "ComprobantePagoId", "ComprobantePagoId", tipoComprobante.ComprobantePagoId);
            return View(tipoComprobante);
        }

        // GET: TipoComprobante/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoComprobante tipoComprobante = db.TiposComprobante.Find(id);
            if (tipoComprobante == null)
            {
                return HttpNotFound();
            }
            return View(tipoComprobante);
        }

        // POST: TipoComprobante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoComprobante tipoComprobante = db.TiposComprobante.Find(id);
            db.TiposComprobante.Remove(tipoComprobante);
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
