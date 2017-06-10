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
    public class TipoTransporteController : Controller
    {
        //private PaqueteTuristicoContext db = new PaqueteTuristicoContext();
        private readonly IUnityOfWork _UnityOfWork;

        public TipoTransporteController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public TipoTransporteController()
        {

        }

        // GET: TipoTransporte
        public ActionResult Index()
        {
            //return View(db.TiposTransporte.ToList());
            return View(_UnityOfWork.TipoTransportes.GetAll());
        }

        // GET: TipoTransporte/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //TipoTransporte tipoTransporte = db.TiposTransporte.Find(id);
            TipoTransporte tipoTransporte = _UnityOfWork.TipoTransportes.Get(id);
            if (tipoTransporte == null)
            {
                return HttpNotFound();
            }
            return View(tipoTransporte);
        }

        // GET: TipoTransporte/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoTransporte/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoTransporteId,TransporteId")] TipoTransporte tipoTransporte)
        {
            if (ModelState.IsValid)
            {
                //db.TiposTransporte.Add(tipoTransporte);
                _UnityOfWork.TipoTransportes.Add(tipoTransporte);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoTransporte);
        }

        // GET: TipoTransporte/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //TipoTransporte tipoTransporte = db.TiposTransporte.Find(id);
            TipoTransporte tipoTransporte = _UnityOfWork.TipoTransportes.Get(id);
            if (tipoTransporte == null)
            {
                return HttpNotFound();
            }
            return View(tipoTransporte);
        }

        // POST: TipoTransporte/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoTransporteId,TransporteId")] TipoTransporte tipoTransporte)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(tipoTransporte).State = EntityState.Modified;
                _UnityOfWork.StateModedified(tipoTransporte);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoTransporte);
        }

        // GET: TipoTransporte/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //TipoTransporte tipoTransporte = db.TiposTransporte.Find(id);
            TipoTransporte tipoTransporte = _UnityOfWork.TipoTransportes.Get(id);
            if (tipoTransporte == null)
            {
                return HttpNotFound();
            }
            return View(tipoTransporte);
        }

        // POST: TipoTransporte/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //TipoTransporte tipoTransporte = db.TiposTransporte.Find(id);
            TipoTransporte tipoTransporte = _UnityOfWork.TipoTransportes.Get(id);
            //db.TiposTransporte.Remove(tipoTransporte);
            _UnityOfWork.TipoTransportes.Delete(tipoTransporte);

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
