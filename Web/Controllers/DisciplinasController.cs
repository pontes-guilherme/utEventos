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
        private dbEventosEntities db = new dbEventosEntities();

        // GET: Disciplinas
        public ActionResult Index()
        {
            return View(pnDisciplinas.Listar());
        }

        //// GET: Disciplinas/Details/5
        //public ActionResult Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Disciplina disciplina = pnDisciplinas.Pesquisar(id);
        //    if (disciplina == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(disciplina);
        //}

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
                //db.Disciplinas.Add(disciplina);
                //db.SaveChanges();
                disciplina.Eventos = null;
                pnDisciplinas.Inserir(disciplina,null);
                return RedirectToAction("Index");
            }

            return View(disciplina);
        }

        //// GET: Disciplinas/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Disciplina disciplina = db.Disciplinas.Find(id);
        //    if (disciplina == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(disciplina);
        //}

        //// POST: Disciplinas/Edit/5
        //// Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        //// obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "nome")] Disciplina disciplina)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(disciplina).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(disciplina);
        //}

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
            Disciplina disciplina = db.Disciplinas.Find(id);
            //db.Disciplinas.Remove(disciplina);
            //db.SaveChanges();
            pnDisciplinas.Excluir(disciplina);
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
