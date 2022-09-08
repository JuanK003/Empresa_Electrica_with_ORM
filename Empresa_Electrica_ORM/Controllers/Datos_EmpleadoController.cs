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
    public class Datos_EmpleadoController : Controller
    {
        private Empresa_ElectricaContext db = new Empresa_ElectricaContext();

        // GET: Datos_Empleado
        public ActionResult Index()
        {
            return View(db.Datos_Empleado.ToList());
        }

        // GET: Datos_Empleado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Datos_Empleado datos_Empleado = db.Datos_Empleado.Find(id);
            if (datos_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(datos_Empleado);
        }

        // GET: Datos_Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Datos_Empleado/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Fecha_Contratacion,Salario,Permisos")] Datos_Empleado datos_Empleado)
        {
            if (ModelState.IsValid)
            {
                db.Datos_Empleado.Add(datos_Empleado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(datos_Empleado);
        }

        // GET: Datos_Empleado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Datos_Empleado datos_Empleado = db.Datos_Empleado.Find(id);
            if (datos_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(datos_Empleado);
        }

        // POST: Datos_Empleado/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Fecha_Contratacion,Salario,Permisos")] Datos_Empleado datos_Empleado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datos_Empleado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(datos_Empleado);
        }

        // GET: Datos_Empleado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Datos_Empleado datos_Empleado = db.Datos_Empleado.Find(id);
            if (datos_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(datos_Empleado);
        }

        // POST: Datos_Empleado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Datos_Empleado datos_Empleado = db.Datos_Empleado.Find(id);
            db.Datos_Empleado.Remove(datos_Empleado);
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
