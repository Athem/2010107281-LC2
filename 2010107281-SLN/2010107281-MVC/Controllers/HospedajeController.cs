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
    public class HospedajeController : Controller
    {
        //private PaqueteTuristicoContext db = new PaqueteTuristicoContext();
        private readonly IUnityOfWork _UnityOfWork;

        public HospedajeController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public HospedajeController()
        {

        }

        // GET: Hospedaje
        public ActionResult Index()
        {
            //return View(db.ServiciosTuristicos.ToList());
            return View(_UnityOfWork.Hospedajes.GetAll());
        }

        // GET: Hospedaje/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Hospedaje hospedaje = db.ServiciosTuristicos.Find(id);
            Hospedaje hospedaje = _UnityOfWork.Hospedajes.Get(id);
            if (hospedaje == null)
            {
                return HttpNotFound();
            }
            return View(hospedaje);
        }

        // GET: Hospedaje/Create Hospejade
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hospedaje/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServicioTuristicoId,Fecha,Hora,Direccion,HospedajeId,Descripcion,TipoHospedajeId,CalificacionHospedajeId,CategoriaHospedajeId")] Hospedaje hospedaje)
        {
            if (ModelState.IsValid)
            {
                //db.ServiciosTuristicos.Add(hospedaje);
                _UnityOfWork.Hospedajes.Add(hospedaje);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hospedaje);
        }

        // GET: Hospedaje/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Hospedaje hospedaje = db.ServiciosTuristicos.Find(id);
            Hospedaje hospedaje = _UnityOfWork.Hospedajes.Get(id);
            if (hospedaje == null)
            {
                return HttpNotFound();
            }
            return View(hospedaje);
        }

        // POST: Hospedaje/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServicioTuristicoId,Fecha,Hora,Direccion,HospedajeId,Descripcion,TipoHospedajeId,CalificacionHospedajeId,CategoriaHospedajeId")] Hospedaje hospedaje)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(hospedaje).State = EntityState.Modified;
                _UnityOfWork.StateModedified(hospedaje);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hospedaje);
        }

        // GET: Hospedaje/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Hospedaje hospedaje = db.ServiciosTuristicos.Find(id);
            Hospedaje hospedaje = _UnityOfWork.Hospedajes.Get(id);
            if (hospedaje == null)
            {
                return HttpNotFound();
            }
            return View(hospedaje);
        }

        // POST: Hospedaje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Hospedaje hospedaje = db.ServiciosTuristicos.Find(id);
            Hospedaje hospedaje = _UnityOfWork.Hospedajes.Get(id);
            //db.ServiciosTuristicos.Remove(hospedaje);
            _UnityOfWork.Hospedajes.Delete(hospedaje);

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
