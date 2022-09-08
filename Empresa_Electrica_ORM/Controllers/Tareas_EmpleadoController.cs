using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Empresa_Electrica_ORM.Data;
using Empresa_Electrica_ORM.Models;

namespace Empresa_Electrica_ORM.Controllers
{
    public class Tareas_EmpleadoController : Controller
    {
        private Empresa_ElectricaContext db = new Empresa_ElectricaContext();

        // GET: Tareas_Empleado
        public ActionResult Index()
        {
            return View(db.Tareas_Empleado.ToList());
        }

        // GET: Tareas_Empleado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tareas_Empleado tareas_Empleado = db.Tareas_Empleado.Find(id);
            if (tareas_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(tareas_Empleado);
        }

        // GET: Tareas_Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tareas_Empleado/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre_Tarea,Descripcion")] Tareas_Empleado tareas_Empleado)
        {
            if (ModelState.IsValid)
            {
                db.Tareas_Empleado.Add(tareas_Empleado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tareas_Empleado);
        }

        // GET: Tareas_Empleado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tareas_Empleado tareas_Empleado = db.Tareas_Empleado.Find(id);
            if (tareas_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(tareas_Empleado);
        }

        // POST: Tareas_Empleado/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre_Tarea,Descripcion")] Tareas_Empleado tareas_Empleado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tareas_Empleado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tareas_Empleado);
        }

        // GET: Tareas_Empleado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tareas_Empleado tareas_Empleado = db.Tareas_Empleado.Find(id);
            if (tareas_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(tareas_Empleado);
        }

        // POST: Tareas_Empleado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tareas_Empleado tareas_Empleado = db.Tareas_Empleado.Find(id);
            db.Tareas_Empleado.Remove(tareas_Empleado);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
