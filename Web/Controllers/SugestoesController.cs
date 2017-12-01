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
    public class SugestoesController : Controller
    {
        private dbEventosEntities db = new dbEventosEntities();

        // GET: Sugestoes
        public ActionResult Index()
        {
            var sugestoes = db.Sugestoes.Include(s => s.Usuario);
            return View(sugestoes.ToList());
        }

        // GET: Sugestoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sugesto sugesto = db.Sugestoes.Find(id);
            if (sugesto == null)
            {
                return HttpNotFound();
            }
            return View(sugesto);
        }

        // GET: Sugestoes/Create
        public ActionResult Create()
        {
            ViewBag.Usuario_email = new SelectList(db.Usuarios, "email", "nome");
            return View();
        }

        // POST: Sugestoes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,titulo,descricao,Usuario_email,data_criacao")] Sugesto sugesto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Sugestoes.Add(sugesto);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.Usuario_email = new SelectList(db.Usuarios, "email", "nome", sugesto.Usuario_email);
        //    return View(sugesto);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "titulo,descricao")] Sugesto s)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //"Id,titulo,descricao,Usuario_email,data_criacao"
                    //db.Usuarios.Add(usuario);
                    //db.SaveChanges();
                    s.Usuario_email = System.Web.HttpContext.Current.Session["email"].ToString();
                    pnSugestoes.Inserir(s, null);
                    return RedirectToAction("Index");
                }
                catch (Exception) { }
            }

            return View();
        }

        //// GET: Sugestoes/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Sugesto sugesto = db.Sugestoes.Find(id);
        //    if (sugesto == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.Usuario_email = new SelectList(db.Usuarios, "email", "nome", sugesto.Usuario_email);
        //    return View(sugesto);
        //}

        //// POST: Sugestoes/Edit/5
        //// Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        //// obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,titulo,descricao,Usuario_email,data_criacao")] Sugesto sugesto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(sugesto).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.Usuario_email = new SelectList(db.Usuarios, "email", "nome", sugesto.Usuario_email);
        //    return View(sugesto);
        //}

        // GET: Sugestoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sugesto sugesto = db.Sugestoes.Find(id);
            if (sugesto == null)
            {
                return HttpNotFound();
            }
            return View(sugesto);
        }

        // POST: Sugestoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sugesto sugesto = db.Sugestoes.Find(id);
            db.Sugestoes.Remove(sugesto);
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
