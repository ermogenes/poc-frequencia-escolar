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
    public class AlunoController : Controller
    {
        private escolaEntities db = new escolaEntities();

        // GET: Aluno
        public ActionResult Index()
        {
            var aluno = db.aluno.Include(a => a.responsavel).Include(a => a.turma);
            return View(aluno.ToList());
        }

        // GET: Aluno/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            aluno aluno = db.aluno.Find(id);
            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(aluno);
        }

        // GET: Aluno/Create
        public ActionResult Create()
        {
            ViewBag.cd_responsavel = new SelectList(db.responsavel, "cd_responsavel", "nm_responsavel");
            ViewBag.cd_turma = new SelectList(db.turma, "cd_turma", "dc_turma");
            return View();
        }

        // POST: Aluno/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cd_aluno,nm_aluno,cd_turma,cd_responsavel")] aluno aluno)
        {
            if (ModelState.IsValid)
            {
                db.aluno.Add(aluno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.cd_responsavel = new SelectList(db.responsavel, "cd_responsavel", "nm_responsavel", aluno.cd_responsavel);
            ViewBag.cd_turma = new SelectList(db.turma, "cd_turma", "dc_turma", aluno.cd_turma);
            return View(aluno);
        }

        // GET: Aluno/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            aluno aluno = db.aluno.Find(id);
            if (aluno == null)
            {
                return HttpNotFound();
            }
            ViewBag.cd_responsavel = new SelectList(db.responsavel, "cd_responsavel", "nm_responsavel", aluno.cd_responsavel);
            ViewBag.cd_turma = new SelectList(db.turma, "cd_turma", "dc_turma", aluno.cd_turma);
            return View(aluno);
        }

        // POST: Aluno/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cd_aluno,nm_aluno,cd_turma,cd_responsavel")] aluno aluno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aluno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.cd_responsavel = new SelectList(db.responsavel, "cd_responsavel", "nm_responsavel", aluno.cd_responsavel);
            ViewBag.cd_turma = new SelectList(db.turma, "cd_turma", "dc_turma", aluno.cd_turma);
            return View(aluno);
        }

        // GET: Aluno/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            aluno aluno = db.aluno.Find(id);
            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(aluno);
        }

        // POST: Aluno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            aluno aluno = db.aluno.Find(id);
            db.aluno.Remove(aluno);
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
