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
    public class AdministradorController : Controller
    {
        private dbEventosEntities db = new dbEventosEntities();

        public ActionResult Main()
        {
            return View();
        }

        // GET: Administrador
        public ActionResult Index()
        {
            return View(db.Categorias.ToList());
        }

        //// GET: Administrador/Details/5
        //public ActionResult Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Categoria categoria = db.Categorias.Find(id);
        //    if (categoria == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(categoria);
        //}

        // GET: Administrador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrador/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "nome")] Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                db.Categorias.Add(categoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        //// GET: Administrador/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Categoria categoria = db.Categorias.Find(id);
        //    if (categoria == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(categoria);
        //}

        //// POST: Administrador/Edit/5
        //// Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        //// obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "nome")] Categoria categoria)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(categoria).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(categoria);
        //}

        // GET: Administrador/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = db.Categorias.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        // POST: Administrador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Categoria categoria = db.Categorias.Find(id);
            db.Categorias.Remove(categoria);
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
