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
    public class PaqueteController : Controller
    {
        //private PaqueteTuristicoContext db = new PaqueteTuristicoContext();
        private readonly IUnityOfWork _UnityOfWork;

        public PaqueteController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public PaqueteController()
        {

        }

        // GET: Paquete
        public ActionResult Index()
        {
            //return View(db.Paquetes.ToList());
            return View(_UnityOfWork.Paquetes.GetAll());
        }

        // GET: Paquete/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Paquete paquete = db.Paquetes.Find(id);
            Paquete paquete = _UnityOfWork.Paquetes.Get(id);
            if (paquete == null)
            {
                return HttpNotFound();
            }
            return View(paquete);
        }

        // GET: Paquete/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Paquete/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PaqueteId")] Paquete paquete)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.Paquetes.Add(paquete);
                _UnityOfWork.Paquetes.Add(paquete);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paquete);
        }

        // GET: Paquete/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Paquete paquete = db.Paquetes.Find(id);
            Paquete paquete = _UnityOfWork.Paquetes.Get(id);
            if (paquete == null)
            {
                return HttpNotFound();
            }
            return View(paquete);
        }

        // POST: Paquete/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PaqueteId")] Paquete paquete)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(paquete).State = EntityState.Modified;
                _UnityOfWork.StateModedified(paquete);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(paquete);
        }

        // GET: Paquete/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Paquete paquete = db.Paquetes.Find(id);
            Paquete paquete = _UnityOfWork.Paquetes.Get(id);
            if (paquete == null)
            {
                return HttpNotFound();
            }
            return View(paquete);
        }

        // POST: Paquete/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Paquete paquete = db.Paquetes.Find(id);
            Paquete paquete = _UnityOfWork.Paquetes.Get(id);
            //db.Paquetes.Remove(paquete);
            _UnityOfWork.Paquetes.Delete(paquete);

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
