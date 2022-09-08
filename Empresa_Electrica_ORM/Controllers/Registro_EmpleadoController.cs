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
    public class Registro_EmpleadoController : Controller
    {
        private Empresa_ElectricaContext db = new Empresa_ElectricaContext();

        // GET: Registro_Empleado
        public ActionResult Index()
        {
            return View(db.Registro_Empleado.ToList());
        }

        // GET: Registro_Empleado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registro_Empleado registro_Empleado = db.Registro_Empleado.Find(id);
            if (registro_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(registro_Empleado);
        }

        // GET: Registro_Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registro_Empleado/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Hora_Entrada,Hora_Salida")] Registro_Empleado registro_Empleado)
        {
            if (ModelState.IsValid)
            {
                db.Registro_Empleado.Add(registro_Empleado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(registro_Empleado);
        }

        // GET: Registro_Empleado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registro_Empleado registro_Empleado = db.Registro_Empleado.Find(id);
            if (registro_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(registro_Empleado);
        }

        // POST: Registro_Empleado/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Hora_Entrada,Hora_Salida")] Registro_Empleado registro_Empleado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registro_Empleado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registro_Empleado);
        }

        // GET: Registro_Empleado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registro_Empleado registro_Empleado = db.Registro_Empleado.Find(id);
            if (registro_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(registro_Empleado);
        }

        // POST: Registro_Empleado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Registro_Empleado registro_Empleado = db.Registro_Empleado.Find(id);
            db.Registro_Empleado.Remove(registro_Empleado);
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
