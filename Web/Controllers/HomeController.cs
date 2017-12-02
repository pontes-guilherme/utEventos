using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelo.DAO;
using Modelo.PN;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Página de descrição da aplicação.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Página de Contatos.";

        //    return View();
        //}

        //public ActionResult Sugestoes()
        //{
        //    ViewBag.Message = "Página de Sugestões.";

        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Sugestoes([Bind(Include = "titulo,descricao")] Sugesto s)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            //"Id,titulo,descricao,Usuario_email,data_criacao"
        //            //db.Usuarios.Add(usuario);
        //            //db.SaveChanges();
        //            s.Usuario_email = System.Web.HttpContext.Current.Session["email"].ToString();
        //            pnSugestoes.Inserir(s);
        //            return RedirectToAction("Index");
        //        }
        //        catch (Exception) { }
        //    }

        //    return View();
        //}
    }
}