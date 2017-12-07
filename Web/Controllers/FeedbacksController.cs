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
    public class FeedbacksController : Controller
    {
        private dbEventosEntities db = new dbEventosEntities();

        // GET: Feedbacks/Create
        public ActionResult Create(int id)
        {
            Feedback f = new Feedback();
            f.EventoId = id;
            return View(f);
        }

        // POST: Feedbacks/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "titulo,descricao,EventoId")] Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedback.Usuario_email = System.Web.HttpContext.Current.Session["email"].ToString();
                pnFeedback.Inserir(feedback,null);
                return RedirectToAction("Details", "Eventoes", new { id = feedback.EventoId });
            }

            ViewBag.EventoId = new SelectList(db.Eventoes, "Id", "nome", feedback.EventoId);
            ViewBag.Usuario_email = new SelectList(db.Usuarios, "email", "nome", feedback.Usuario_email);
            return RedirectToAction("Details", "Eventoes", new { id=feedback.EventoId });
        }

        // GET: Feedbacks/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feedback feedback = pnFeedback.Pesquisar(id);
            if (feedback == null)
            {
                return HttpNotFound();
            }
            return View(feedback);
        }

        // POST: Feedbacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Feedback feedback = pnFeedback.Pesquisar(id);
            pnFeedback.Excluir(feedback);
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
