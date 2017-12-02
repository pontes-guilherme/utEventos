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
using System.Globalization;

namespace Web.Controllers
{
    public class EventoesController : Controller
    {
        private dbEventosEntities db = new dbEventosEntities();

        // GET: Eventoes
        public ActionResult Index()
        {
            var eventoes = db.Eventoes.Include(e => e.Usuario).Include(e => e.Categoria);
            return View(eventoes.ToList());
        }

        // GET: Eventoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = db.Eventoes.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            return View(evento);
        }

        public ActionResult SignUp(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = db.Eventoes.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }

            if (pnInscricoes.Pesquisar(id, System.Web.HttpContext.Current.Session["email"].ToString()) == null)
            {
                pnInscricoes.Inserir(id, System.Web.HttpContext.Current.Session["email"].ToString());
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("ja inscrito");
            }

            return RedirectToAction("Details", new { id = evento.Id });
        }

        public ActionResult SignOut(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = db.Eventoes.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }

            Inscricao inscr = pnInscricoes.Pesquisar(id, System.Web.HttpContext.Current.Session["email"].ToString());
            if (inscr != null)
            {
                pnInscricoes.Excluir(inscr);
            }

            return RedirectToAction("Details", new { id = evento.Id });
        }

        // GET: Eventoes/Create
        public ActionResult Create()
        {
            //ViewBag.criador = new SelectList(db.Usuarios, "email", "nome");
            ViewBag.Categoria_nome = new SelectList(db.Categorias, "nome", "nome");
            ViewBag.Disciplina_nome = new SelectList(db.Disciplinas, "nome", "nome");
            Evento evento = new Evento();
            string inicio = (DateTime.Now).AddDays(1).ToString("yyyy-MM-ddThh:mm");
            string fim = (DateTime.Now).AddDays(1).ToString("yyyy-MM-ddThhmm");
            evento.data_inicio = DateTime.ParseExact(inicio, "yyyy-MM-ddThh:mm", CultureInfo.InvariantCulture);
            evento.data_fim = DateTime.ParseExact(fim, "yyyy-MM-ddThhmm", CultureInfo.InvariantCulture);
            //System.Diagnostics.Debug.WriteLine(evento.data_inicio.ToString());
            //System.Diagnostics.Debug.WriteLine(evento.data_fim.ToString());
            return View(evento);
        }

        // POST: Eventoes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "nome,data_inicio,data_fim,capacidade,escopo,Disciplina_nome,importante,Categoria_nome")] Evento evento)
        {
            if (ModelState.IsValid)
            {
                if(evento.capacidade == null)
                {
                    evento.capacidade = 0;
                }
                evento.criador = System.Web.HttpContext.Current.Session["email"].ToString();
                pnEventos.Inserir(evento, null);
                return RedirectToAction("Index");
            }

            ViewBag.criador = new SelectList(db.Usuarios, "email", "nome", evento.criador);
            ViewBag.Disciplina_nome = new SelectList(db.Categorias, "nome", "nome", evento.Disciplina_nome);
            ViewBag.Categoria_nome = new SelectList(db.Categorias, "nome", "nome", evento.Categoria_nome);
            return View(evento);
        }

        // GET: Eventoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = db.Eventoes.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            ViewBag.criador = new SelectList(db.Usuarios, "email", "nome", evento.criador);
            ViewBag.Categoria_nome = new SelectList(db.Categorias, "nome", "nome", evento.Categoria_nome);
            return View(evento);
        }

        // POST: Eventoes/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nome,data_inicio,data_fim,escopo,importante,Categoria_nome")] Evento evento)
        {
            if (ModelState.IsValid)
            {
                evento.criador = System.Web.HttpContext.Current.Session["email"].ToString();
                //db.Entry(evento).State = EntityState.Modified;
                //db.SaveChanges();
                pnEventos.Alterar(evento, null);
                return RedirectToAction("Index");
            }
            ViewBag.criador = new SelectList(db.Usuarios, "email", "nome", evento.criador);
            ViewBag.Categoria_nome = new SelectList(db.Categorias, "nome", "nome", evento.Categoria_nome);
            return View(evento);
        }

        // GET: Eventoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = db.Eventoes.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            return View(evento);
        }

        // POST: Eventoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evento evento = db.Eventoes.Find(id);
            db.Eventoes.Remove(evento);
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
