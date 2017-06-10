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
using _2010107281_PER.Repositories;

namespace _2010107281_MVC.Controllers
{
    public class AlimentacionController : Controller
    {
        //private PaqueteTuristicoContext db = new PaqueteTuristicoContext();
        private readonly IUnityOfWork _UnityOfWork;

        public AlimentacionController(UnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public AlimentacionController()
        {

        }

        // GET: Alimentacion
        public ActionResult Index()
        {
            //return View(db.ServiciosTuristicos.ToList());
            return View(_UnityOfWork.Alimentaciones.GetAll());
        }

        // GET: Alimentacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Alimentacion alimentacion = db.ServiciosTuristicos.Find(id);
            Alimentacion alimentacion = _UnityOfWork.Alimentaciones.Get(id);
            if (alimentacion == null)
            {
                return HttpNotFound();
            }
            return View(alimentacion);
        }

        // GET: Alimentacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alimentacion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServicioTuristicoId,Fecha,Hora,Direccion,AlimentacionId")] Alimentacion alimentacion)
        {
            if (ModelState.IsValid)
            {
                //db.ServiciosTuristicos.Add(alimentacion);
                _UnityOfWork.Alimentaciones.Add(alimentacion);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(alimentacion);
        }

        // GET: Alimentacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Alimentacion alimentacion = db.ServiciosTuristicos.Find(id);
            Alimentacion alimentacion = _UnityOfWork.Alimentaciones.Get(id);
            if (alimentacion == null)
            {
                return HttpNotFound();
            }
            return View(alimentacion);
        }

        // POST: Alimentacion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServicioTuristicoId,Fecha,Hora,Direccion,AlimentacionId")] Alimentacion alimentacion)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(alimentacion).State = EntityState.Modified;
                _UnityOfWork.StateModedified(alimentacion);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(alimentacion);
        }

        // GET: Alimentacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Alimentacion alimentacion = db.ServiciosTuristicos.Find(id);
            Alimentacion alimentacion = _UnityOfWork.Alimentaciones.Get(id);
            if (alimentacion == null)
            {
                return HttpNotFound();
            }
            return View(alimentacion);
        }

        // POST: Alimentacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Alimentacion alimentacion = db.ServiciosTuristicos.Find(id);
            Alimentacion alimentacion = _UnityOfWork.Alimentaciones.Get(id);
            //db.ServiciosTuristicos.Remove(alimentacion);
            _UnityOfWork.Alimentaciones.Delete(alimentacion);
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
