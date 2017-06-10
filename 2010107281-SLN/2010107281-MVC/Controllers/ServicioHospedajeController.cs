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
    public class ServicioHospedajeController : Controller
    {
        //private PaqueteTuristicoContext db = new PaqueteTuristicoContext();
        private readonly IUnityOfWork _UnityOfWork;

        public ServicioHospedajeController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public ServicioHospedajeController()
        {

        }

        // GET: ServicioHospedajes
        public ActionResult Index()
        {
            //return View(db.ServiciosHospdeje.ToList());
            return View(_UnityOfWork.ServicioHospedajes.GetAll());
        }

        // GET: ServicioHospedajes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //ServicioHospedaje servicioHospedaje = db.ServiciosHospdeje.Find(id);
            ServicioHospedaje servicioHospedaje = _UnityOfWork.ServicioHospedajes.Get(id);
            if (servicioHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(servicioHospedaje);
        }

        // GET: ServicioHospedajes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServicioHospedajes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServicioHospedajeId,HospedajeId")] ServicioHospedaje servicioHospedaje)
        {
            if (ModelState.IsValid)
            {
                //db.ServiciosHospdeje.Add(servicioHospedaje);
                _UnityOfWork.ServicioHospedajes.Add(servicioHospedaje);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(servicioHospedaje);
        }

        // GET: ServicioHospedajes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //ServicioHospedaje servicioHospedaje = db.ServiciosHospdeje.Find(id);
            ServicioHospedaje servicioHospedaje = _UnityOfWork.ServicioHospedajes.Get(id);
            if (servicioHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(servicioHospedaje);
        }

        // POST: ServicioHospedajes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServicioHospedajeId,HospedajeId")] ServicioHospedaje servicioHospedaje)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(servicioHospedaje).State = EntityState.Modified;
                _UnityOfWork.StateModedified(servicioHospedaje);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(servicioHospedaje);
        }

        // GET: ServicioHospedajes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //ServicioHospedaje servicioHospedaje = db.ServiciosHospdeje.Find(id);
            ServicioHospedaje servicioHospedaje = _UnityOfWork.ServicioHospedajes.Get(id);
            if (servicioHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(servicioHospedaje);
        }

        // POST: ServicioHospedajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //ServicioHospedaje servicioHospedaje = db.ServiciosHospdeje.Find(id);
            ServicioHospedaje servicioHospedaje = _UnityOfWork.ServicioHospedajes.Get(id);
            //db.ServiciosHospdeje.Remove(servicioHospedaje);
            _UnityOfWork.ServicioHospedajes.Delete(servicioHospedaje);

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
