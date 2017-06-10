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
    public class ServicioTuristicoController : Controller
    {
        //private PaqueteTuristicoContext db = new PaqueteTuristicoContext();
        private readonly IUnityOfWork _UnityOfWork;

        public ServicioTuristicoController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public ServicioTuristicoController()
        {

        }

        // GET: ServicioTuristico
        public ActionResult Index()
        {
            //return View(db.ServiciosTuristicos.ToList());
            return View(_UnityOfWork.ServicioTuristicos.GetAll());
        }

        // GET: ServicioTuristico/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //ServicioTuristico servicioTuristico = db.ServiciosTuristicos.Find(id);
            ServicioTuristico servicioTuristico = _UnityOfWork.ServicioTuristicos.Get(id);
            if (servicioTuristico == null)
            {
                return HttpNotFound();
            }
            return View(servicioTuristico);
        }

        // GET: ServicioTuristico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServicioTuristico/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServicioTuristicoId,Fecha,Hora,Direccion")] ServicioTuristico servicioTuristico)
        {
            if (ModelState.IsValid)
            {
                //db.ServiciosTuristicos.Add(servicioTuristico);
                _UnityOfWork.ServicioTuristicos.Add(servicioTuristico);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(servicioTuristico);
        }

        // GET: ServicioTuristico/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //ServicioTuristico servicioTuristico = db.ServiciosTuristicos.Find(id);
            ServicioTuristico servicioTuristico = _UnityOfWork.ServicioTuristicos.Get(id);
            if (servicioTuristico == null)
            {
                return HttpNotFound();
            }
            return View(servicioTuristico);
        }

        // POST: ServicioTuristico/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServicioTuristicoId,Fecha,Hora,Direccion")] ServicioTuristico servicioTuristico)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(servicioTuristico).State = EntityState.Modified;
                _UnityOfWork.StateModedified(servicioTuristico);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(servicioTuristico);
        }

        // GET: ServicioTuristico/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //ServicioTuristico servicioTuristico = db.ServiciosTuristicos.Find(id);
            ServicioTuristico servicioTuristico = _UnityOfWork.ServicioTuristicos.Get(id);
            if (servicioTuristico == null)
            {
                return HttpNotFound();
            }
            return View(servicioTuristico);
        }

        // POST: ServicioTuristico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //ServicioTuristico servicioTuristico = db.ServiciosTuristicos.Find(id);
            ServicioTuristico servicioTuristico = _UnityOfWork.ServicioTuristicos.Get(id);
            //db.ServiciosTuristicos.Remove(servicioTuristico);
            _UnityOfWork.ServicioTuristicos.Delete(servicioTuristico);

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
