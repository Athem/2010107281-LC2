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
    public class PersonasController : Controller
    {
        //private PaqueteTuristicoContext db = new PaqueteTuristicoContext();
        private readonly IUnityOfWork _UnityOfWork;

        public PersonasController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public PersonasController()
        {

        }

        // GET: Personas
        public ActionResult Index()
        {
            //return View(db.Personas.ToList());
            return View(_UnityOfWork.Personas.GetAll());
        }

        // GET: Personas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Persona persona = db.Personas.Find(id);
            Persona persona = _UnityOfWork.Personas.Get(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // GET: Personas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonaId,Nombres,ApellidoPaterno,ApellidoMaterno,Correo,Telefono,Dirección,NumeroDni")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                //db.Personas.Add(persona);
                _UnityOfWork.Personas.Add(persona);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(persona);
        }

        // GET: Personas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = _UnityOfWork.Personas.Get(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: Personas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonaId,Nombres,ApellidoPaterno,ApellidoMaterno,Correo,Telefono,Dirección,NumeroDni")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(persona).State = EntityState.Modified;
                _UnityOfWork.StateModedified(persona);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(persona);
        }

        // GET: Personas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Persona persona = db.Personas.Find(id);
            Persona persona = _UnityOfWork.Personas.Get(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Persona persona = db.Personas.Find(id);
            Persona persona = _UnityOfWork.Personas.Get(id);
            //db.Personas.Remove(persona);
            _UnityOfWork.Personas.Delete(persona);

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
