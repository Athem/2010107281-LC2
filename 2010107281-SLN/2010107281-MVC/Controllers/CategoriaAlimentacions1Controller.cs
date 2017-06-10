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
    public class CategoriaAlimentacions1Controller : Controller
    {
        //private PaqueteTuristicoContext db = new PaqueteTuristicoContext();
        private readonly IUnityOfWork _UnityOfWork;

        public CategoriaAlimentacions1Controller(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public CategoriaAlimentacions1Controller()
        {

        }

        // GET: CategoriaAlimentacions1
        public ActionResult Index()
        {
            //return View(db.CategoriasAlimentacion.ToList());
            return View(_UnityOfWork.CategoriaAlimentaciones.GetAll());
        }

        // GET: CategoriaAlimentacions1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //CategoriaAlimentacion categoriaAlimentacion = db.CategoriasAlimentacion.Find(id);
            CategoriaAlimentacion categoriaAlimentacion = _UnityOfWork.CategoriaAlimentaciones.Get(id);
            if (categoriaAlimentacion == null)
            {
                return HttpNotFound();
            }
            return View(categoriaAlimentacion);
        }

        // GET: CategoriaAlimentacions1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaAlimentacions1/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoriaAlimentacionId")] CategoriaAlimentacion categoriaAlimentacion)
        {
            if (ModelState.IsValid)
            {
                //db.CategoriasAlimentacion.Add(categoriaAlimentacion);
                _UnityOfWork.CategoriaAlimentaciones.Add(categoriaAlimentacion);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriaAlimentacion);
        }

        // GET: CategoriaAlimentacions1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //CategoriaAlimentacion categoriaAlimentacion = db.CategoriasAlimentacion.Find(id);
            CategoriaAlimentacion categoriaAlimentacion = _UnityOfWork.CategoriaAlimentaciones.Get(id);
            if (categoriaAlimentacion == null)
            {
                return HttpNotFound();
            }
            return View(categoriaAlimentacion);
        }

        // POST: CategoriaAlimentacions1/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoriaAlimentacionId")] CategoriaAlimentacion categoriaAlimentacion)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(categoriaAlimentacion).State = EntityState.Modified;
                _UnityOfWork.StateModedified(categoriaAlimentacion);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaAlimentacion);
        }

        // GET: CategoriaAlimentacions1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //CategoriaAlimentacion categoriaAlimentacion = db.CategoriasAlimentacion.Find(id);
            CategoriaAlimentacion categoriaAlimentacion = _UnityOfWork.CategoriaAlimentaciones.Get(id);
            if (categoriaAlimentacion == null)
            {
                return HttpNotFound();
            }
            return View(categoriaAlimentacion);
        }

        // POST: CategoriaAlimentacions1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //CategoriaAlimentacion categoriaAlimentacion = db.CategoriasAlimentacion.Find(id);
            CategoriaAlimentacion categoriaAlimentacion = _UnityOfWork.CategoriaAlimentaciones.Get(id);
            //db.CategoriasAlimentacion.Remove(categoriaAlimentacion);
            _UnityOfWork.CategoriaAlimentaciones.Delete(categoriaAlimentacion);
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
