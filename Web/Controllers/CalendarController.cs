using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelo.DAO;
using Modelo.PN;
using System.Web.Helpers;

namespace Web.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public JsonResult GetEvents()
        {
            string user = "";
            if(System.Web.HttpContext.Current.Session["email"] != null)
            {
                user = System.Web.HttpContext.Current.Session["email"].ToString();
            }

            List<Evento> events = pnEventos.Listar(user,"");
            System.Diagnostics.Debug.WriteLine(events.Count());

            var eventList = from e in events
                            select new
                            {
                                id = e.Id,
                                title = e.nome,
                                start = e.data_inicio,
                                end = e.data_fim,
                                vagas = e.capacidade - e.Inscricoes.Count()
                            };
            var rows = eventList.ToArray();

            return Json(rows, JsonRequestBehavior.AllowGet);
        }
    }
}