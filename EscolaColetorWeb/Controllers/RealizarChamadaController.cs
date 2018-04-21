using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EscolaColetorWeb.Entity;
using EscolaColetorWeb.Models;

namespace EscolaColetorWeb.Controllers
{
    public class RealizarChamadaController : Controller
    {
        private escolaEntities db = new escolaEntities();


        // GET: RealizarChamada -- escola
        public ActionResult RealizarChamada(int? t, DateTime? data)
        {
            if (t == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (data == null)
            {
                data = DateTime.Today.Date;
            }

            RealizarChamadaModel rc = new RealizarChamadaModel();
            rc.data = data.GetValueOrDefault();
            rc.turma = db.turma.Find(t);

            rc.alunos = new List<AlunoChamada>();
            foreach (var a in db.sp_lista_chamada(rc.data, rc.turma.cd_turma)) {
                rc.alunos.Add(new AlunoChamada() {
                    cd_aluno = a.cd_aluno,
                    nm_aluno = a.nm_aluno,
                    cd_chamada = a.cd_chamada,
                    dt_chamada = a.dt_chamada,
                    in_presente = a.in_presente,
                });
            }
            return View(rc);
        }



        // GET: RealizarChamada
        public ActionResult Index()
        {
            var chamada = db.chamada.Include(c => c.aluno);
            return View(db.turma.ToList());
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult ReceberChamada(int? cd_chamada, DateTime? dt_chamada, int cd_aluno = 1, bool in_presente = true, int t = 1)
        public ActionResult RealizarChamada([Bind(Include = "cd_chamada,dt_chamada,cd_aluno,in_presente,nm_aluno")] AlunoChamada ac, int t)
        {
            if (ac.dt_chamada == null) ac.dt_chamada = DateTime.Now;

            //if (ModelState.IsValid)
            //{
                // é alteração?
                if (ac.cd_chamada != null)
                {
                    var ch = db.chamada.Find(ac.cd_chamada);
                    ch.dt_chamada = ac.dt_chamada.GetValueOrDefault();
                    ch.cd_aluno = ac.cd_aluno;
                    ch.in_presente = ac.in_presente.GetValueOrDefault();
                    db.Entry(ch).State = EntityState.Modified;
                }
                else // é inclusão
                {
                    var ch = new chamada
                    {
                        cd_chamada = ac.cd_chamada.GetValueOrDefault(),
                        dt_chamada = ac.dt_chamada.GetValueOrDefault(),
                        cd_aluno = ac.cd_aluno,
                        in_presente = ac.in_presente.GetValueOrDefault(),
                    };
                    db.chamada.Add(ch);     
                }
                db.SaveChanges();
            //}
            return RedirectToAction("RealizarChamada", new { t = t, data = ac.dt_chamada.GetValueOrDefault().Date });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cd_chamada,dt_chamada,cd_aluno,in_presente")] chamada chamada)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chamada).State = EntityState.Modified;
                db.SaveChanges();
                
            }
            return RedirectToAction("RealizarChamada", new { t = chamada.aluno.cd_turma, data = chamada.dt_chamada.Date });
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
