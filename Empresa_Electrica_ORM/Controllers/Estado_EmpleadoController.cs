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
    public class Estado_EmpleadoController : Controller
    {
        private Empresa_ElectricaContext db = new Empresa_ElectricaContext();

        // GET: Estado_Empleado
        public ActionResult Index()
        {
            return View(db.Estado_Empleado.ToList());
        }

        // GET: Estado_Empleado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estado_Empleado estado_Empleado = db.Estado_Empleado.Find(id);
            if (estado_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(estado_Empleado);
        }

        // GET: Estado_Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estado_Empleado/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Estado")] Estado_Empleado estado_Empleado)
        {
            if (ModelState.IsValid)
            {
                db.Estado_Empleado.Add(estado_Empleado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estado_Empleado);
        }

        // GET: Estado_Empleado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estado_Empleado estado_Empleado = db.Estado_Empleado.Find(id);
            if (estado_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(estado_Empleado);
        }

        // POST: Estado_Empleado/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Estado")] Estado_Empleado estado_Empleado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estado_Empleado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estado_Empleado);
        }

        // GET: Estado_Empleado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estado_Empleado estado_Empleado = db.Estado_Empleado.Find(id);
            if (estado_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(estado_Empleado);
        }

        // POST: Estado_Empleado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estado_Empleado estado_Empleado = db.Estado_Empleado.Find(id);
            db.Estado_Empleado.Remove(estado_Empleado);
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
