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
    public class MedioPagoController : Controller
    {
        //private PaqueteTuristicoContext db = new PaqueteTuristicoContext();
        private readonly IUnityOfWork _UnityOfWork;

        public MedioPagoController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public MedioPagoController()
        {

        }

        // GET: MedioPago
        public ActionResult Index()
        {
            //return View(db.MediosPago.ToList());
            return View(_UnityOfWork.MedioPagos.GetAll());
        }

        // GET: MedioPago/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //MedioPago medioPago = db.MediosPago.Find(id);
            MedioPago medioPago = _UnityOfWork.MedioPagos.Get(id);
            if (medioPago == null)
            {
                return HttpNotFound();
            }
            return View(medioPago);
        }

        // GET: MedioPago/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedioPago/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MedioPagoId")] MedioPago medioPago)
        {
            if (ModelState.IsValid)
            {
                //db.MediosPago.Add(medioPago);
                _UnityOfWork.MedioPagos.Add(medioPago);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(medioPago);
        }

        // GET: MedioPago/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //MedioPago medioPago = db.MediosPago.Find(id);
            MedioPago medioPago = _UnityOfWork.MedioPagos.Get(id);
            if (medioPago == null)
            {
                return HttpNotFound();
            }
            return View(medioPago);
        }

        // POST: MedioPago/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MedioPagoId")] MedioPago medioPago)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(medioPago).State = EntityState.Modified;
                _UnityOfWork.StateModedified(medioPago);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medioPago);
        }

        // GET: MedioPago/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //MedioPago medioPago = db.MediosPago.Find(id);
            MedioPago medioPago = _UnityOfWork.MedioPagos.Get(id);
            if (medioPago == null)
            {
                return HttpNotFound();
            }
            return View(medioPago);
        }

        // POST: MedioPago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //MedioPago medioPago = db.MediosPago.Find(id);
            MedioPago medioPago = _UnityOfWork.MedioPagos.Get(id);
            //db.MediosPago.Remove(medioPago);
            _UnityOfWork.MedioPagos.Delete(medioPago);

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
