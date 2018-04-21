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
    public class ChamadaController : Controller
    {
        private escolaEntities db = new escolaEntities();

        // GET: Consultar Chamada -- Responsavel
        public ActionResult ConsultarChamada(int? responsavel, DateTime? data)
        {
            if (responsavel == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (data == null)
            {
                data = DateTime.Today.Date;
            }
            var dataDesejada = data;
            var chamada = db.chamada.Where(
                    c => DbFunctions.TruncateTime(c.dt_chamada) == dataDesejada
                    && c.aluno.cd_responsavel == responsavel
                );
            return View(chamada);
        }        

        public JsonResult ConsultarChamadaJson(int responsavel, DateTime data)
        {
            var dataDesejada = data;
            var chamada = db.chamada.Where(
                    c => DbFunctions.TruncateTime(c.dt_chamada) == dataDesejada
                    && c.aluno.cd_responsavel == responsavel
                );

            var chamadaObj = new List<object>();

            foreach(var c in chamada)
            {
                chamadaObj.Add(new
                {
                    c.cd_chamada,
                    dt_chamada = c.dt_chamada.ToString(),
                    c.cd_aluno,
                    c.aluno.nm_aluno,
                    c.in_presente,
                    c.aluno.cd_turma,
                    c.aluno.turma.dc_turma,
                    c.aluno.cd_responsavel,
                    c.aluno.responsavel.nm_responsavel,
                });
            }

            return Json(chamadaObj, JsonRequestBehavior.AllowGet);
        }

        // GET: Chamada
        public ActionResult Index()
        {
            var chamada = db.chamada.Include(c => c.aluno);
            return View(chamada.ToList());
        }        
        
        // GET: Chamada
        public ActionResult EscolherResponsavel()
        {
            return View(db.responsavel.ToList());
        }

        // GET: Chamada/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chamada chamada = db.chamada.Find(id);
            if (chamada == null)
            {
                return HttpNotFound();
            }
            return View(chamada);
        }

        // GET: Chamada/Create
        public ActionResult Create()
        {
            ViewBag.cd_aluno = new SelectList(db.aluno, "cd_aluno", "nm_aluno");
            return View();
        }

        // POST: Chamada/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cd_chamada,dt_chamada,cd_aluno,in_presente")] chamada chamada)
        {
            if (ModelState.IsValid)
            {
                db.chamada.Add(chamada);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.cd_aluno = new SelectList(db.aluno, "cd_aluno", "nm_aluno", chamada.cd_aluno);
            return View(chamada);
        }

        // GET: Chamada/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chamada chamada = db.chamada.Find(id);
            if (chamada == null)
            {
                return HttpNotFound();
            }
            ViewBag.cd_aluno = new SelectList(db.aluno, "cd_aluno", "nm_aluno", chamada.cd_aluno);
            return View(chamada);
        }

        // POST: Chamada/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cd_chamada,dt_chamada,cd_aluno,in_presente")] chamada chamada)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chamada).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.cd_aluno = new SelectList(db.aluno, "cd_aluno", "nm_aluno", chamada.cd_aluno);
            return View(chamada);
        }

        // GET: Chamada/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chamada chamada = db.chamada.Find(id);
            if (chamada == null)
            {
                return HttpNotFound();
            }
            return View(chamada);
        }

        // POST: Chamada/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            chamada chamada = db.chamada.Find(id);
            db.chamada.Remove(chamada);
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
