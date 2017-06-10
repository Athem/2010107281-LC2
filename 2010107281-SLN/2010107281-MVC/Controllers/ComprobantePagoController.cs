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
using _2010107281_ENT.IRepositories;

namespace _2010107281_MVC.Controllers
{
    public class ComprobantePagoController : Controller
    {
        //private PaqueteTuristicoContext db = new PaqueteTuristicoContext();
        private readonly IUnityOfWork _UnityOfWork;

        public ComprobantePagoController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public ComprobantePagoController()
        {

        }

        // GET: ComprobantePago
        public ActionResult Index()
        {
            //return View(db.ComprobantesPago.ToList());
            return View(_UnityOfWork.ComprobantePagos.GetAll());
        }

        // GET: ComprobantePago/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //ComprobantePago comprobantePago = db.ComprobantesPago.Find(id);
            ComprobantePago comprobantePago = _UnityOfWork.ComprobantePagos.Get(id);
            if (comprobantePago == null)
            {
                return HttpNotFound();
            }
            return View(comprobantePago);
        }

        // GET: ComprobantePago/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ComprobantePago/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ComprobantePagoId,Descripcion")] ComprobantePago comprobantePago)
        {
            if (ModelState.IsValid)
            {
                //db.ComprobantesPago.Add(comprobantePago);
                _UnityOfWork.ComprobantePagos.Add(comprobantePago);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(comprobantePago);
        }

        // GET: ComprobantePago/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //ComprobantePago comprobantePago = db.ComprobantesPago.Find(id);
            ComprobantePago comprobantePago = _UnityOfWork.ComprobantePagos.Get(id);
            if (comprobantePago == null)
            {
                return HttpNotFound();
            }
            return View(comprobantePago);
        }

        // POST: ComprobantePago/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ComprobantePagoId,Descripcion")] ComprobantePago comprobantePago)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(comprobantePago).State = EntityState.Modified;
                _UnityOfWork.StateModedified(comprobantePago);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(comprobantePago);
        }

        // GET: ComprobantePago/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //ComprobantePago comprobantePago = db.ComprobantesPago.Find(id);
            ComprobantePago comprobantePago = _UnityOfWork.ComprobantePagos.Get(id);
            if (comprobantePago == null)
            {
                return HttpNotFound();
            }
            return View(comprobantePago);
        }

        // POST: ComprobantePago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //ComprobantePago comprobantePago = db.ComprobantesPago.Find(id);
            ComprobantePago comprobantePago = _UnityOfWork.ComprobantePagos.Get(id);
            //db.ComprobantesPago.Remove(comprobantePago);
            _UnityOfWork.ComprobantePagos.Delete(comprobantePago);

            //db.SaveChanges();
            _UnityOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
                _UnityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
