using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Modelo.DAO;
using Modelo.PN;

namespace Web.Controllers
{
    public class DisciplinasController : Controller
    {
        // GET: Disciplinas
        public ActionResult Index()
        {
            return View(pnDisciplinas.Listar());
        }

        // GET: Disciplinas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Disciplinas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "nome")] Disciplina disciplina)
        {
            if (ModelState.IsValid)
            {
                disciplina.Eventos = null;
                pnDisciplinas.Inserir(disciplina,null);
                return RedirectToAction("Index");
            }

            return View(disciplina);
        }

        // GET: Disciplinas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disciplina disciplina = pnDisciplinas.Pesquisar(id);
            if (disciplina == null)
            {
                return HttpNotFound();
            }
            return View(disciplina);
        }

        // POST: Disciplinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Disciplina disciplina = pnDisciplinas.Pesquisar(id);
            pnDisciplinas.Excluir(disciplina);
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
