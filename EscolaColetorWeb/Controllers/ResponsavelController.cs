using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EscolaColetorWeb.Entity;

namespace EscolaColetorWeb.Controllers
{
    public class ResponsavelController : Controller
    {
        private escolaEntities db = new escolaEntities();

        // GET: Responsavel
        public ActionResult Index()
        {
            return View(db.responsavel.ToList());
        }

        // GET: Responsavel/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            responsavel responsavel = db.responsavel.Find(id);
            if (responsavel == null)
            {
                return HttpNotFound();
            }
            return View(responsavel);
        }

        // GET: Responsavel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Responsavel/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cd_responsavel,nm_responsavel")] responsavel responsavel)
        {
            if (ModelState.IsValid)
            {
                db.responsavel.Add(responsavel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(responsavel);
        }

        // GET: Responsavel/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            responsavel responsavel = db.responsavel.Find(id);
            if (responsavel == null)
            {
                return HttpNotFound();
            }
            return View(responsavel);
        }

        // POST: Responsavel/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cd_responsavel,nm_responsavel")] responsavel responsavel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(responsavel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(responsavel);
        }

        // GET: Responsavel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            responsavel responsavel = db.responsavel.Find(id);
            if (responsavel == null)
            {
                return HttpNotFound();
            }
            return View(responsavel);
        }

        // POST: Responsavel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            responsavel responsavel = db.responsavel.Find(id);
            db.responsavel.Remove(responsavel);
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
