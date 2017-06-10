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
    public class CategoriaTransportesController : Controller
    {
        //private PaqueteTuristicoContext db = new PaqueteTuristicoContext();
        private readonly IUnityOfWork _UnityOfWork;

        public CategoriaTransportesController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public CategoriaTransportesController()
        {

        }

        // GET: CategoriaTransportes
        public ActionResult Index()
        {
            //return View(db.CategoriasTransporte.ToList());
            return View(_UnityOfWork.CategoriaTransportes.GetAll());
        }

        // GET: CategoriaTransportes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //CategoriaTransporte categoriaTransporte = db.CategoriasTransporte.Find(id);
            CategoriaTransporte categoriaTransporte = _UnityOfWork.CategoriaTransportes.Get(id);
            if (categoriaTransporte == null)
            {
                return HttpNotFound();
            }
            return View(categoriaTransporte);
        }

        // GET: CategoriaTransportes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaTransportes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoriaTransporteId,TransporteId")] CategoriaTransporte categoriaTransporte)
        {
            if (ModelState.IsValid)
            {
                //db.CategoriasTransporte.Add(categoriaTransporte);
                _UnityOfWork.CategoriaTransportes.Add(categoriaTransporte);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriaTransporte);
        }

        // GET: CategoriaTransportes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //CategoriaTransporte categoriaTransporte = db.CategoriasTransporte.Find(id);
            CategoriaTransporte categoriaTransporte = _UnityOfWork.CategoriaTransportes.Get(id);
            if (categoriaTransporte == null)
            {
                return HttpNotFound();
            }
            return View(categoriaTransporte);
        }

        // POST: CategoriaTransportes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoriaTransporteId,TransporteId")] CategoriaTransporte categoriaTransporte)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(categoriaTransporte).State = EntityState.Modified;
                _UnityOfWork.StateModedified(categoriaTransporte);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaTransporte);
        }

        // GET: CategoriaTransportes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //CategoriaTransporte categoriaTransporte = db.CategoriasTransporte.Find(id);
            CategoriaTransporte categoriaTransporte = _UnityOfWork.CategoriaTransportes.Get(id);
            if (categoriaTransporte == null)
            {
                return HttpNotFound();
            }
            return View(categoriaTransporte);
        }

        // POST: CategoriaTransportes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //CategoriaTransporte categoriaTransporte = db.CategoriasTransporte.Find(id);
            CategoriaTransporte categoriaTransporte = _UnityOfWork.CategoriaTransportes.Get(id);
            //db.CategoriasTransporte.Remove(categoriaTransporte);
            _UnityOfWork.CategoriaTransportes.Delete(categoriaTransporte);
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
