using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Web.Models;
using Modelo.DAO;
using Modelo.PN;

namespace Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public AccountController()
        {
        }

        public AccountController(ApplicationUserManager userManager, ApplicationSignInManager signInManager )
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set 
            { 
                _signInManager = value; 
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            var result = pnUsuarios.Autenticar(model.Email, model.Password);
            if (result)
            {
                System.Diagnostics.Debug.WriteLine("sim");
                Usuario u = pnUsuarios.Pesquisar(model.Email);
                //System.Web.HttpContext.Current.Session["user"] = u;
                System.Web.HttpContext.Current.Session["nome"] = u.nome;
                System.Web.HttpContext.Current.Session["email"] = u.email;
                System.Web.HttpContext.Current.Session["tipo"] = u.tipo;
                return RedirectToLocal(returnUrl);
            }else{
                System.Diagnostics.Debug.WriteLine("nao");
                ModelState.AddModelError("", "Login inválido.");
                return View(model);
            }
        }

        [AllowAnonymous]
        public ActionResult Logout(string returnUrl)
        {
            Usuario u = pnUsuarios.Pesquisar(System.Web.HttpContext.Current.Session["email"].ToString());
            pnUsuarios.sendReminder(u);
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }


        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "nome,email,senha,data_nascimento,tipo")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    usuario.tipo = "Estudante";
                    var result = pnUsuarios.Inserir(usuario);
                    if (result == true)
                    {
                        return RedirectToAction("Login");
                    }
                }
                catch (Exception) { }
            }

            return View(usuario);
        }

        [AllowAnonymous]
        public ActionResult Recuperar()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Recuperar(Usuario u)
        {
            u = pnUsuarios.Pesquisar(u.email);
            if (u != null)
            {
                pnUsuarios.sendMail(u);
            }
            else
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public ActionResult AlterarSenha(string email, string codigo)
        {
            Usuario u = pnUsuarios.Pesquisar(email);
            if (u != null)
            {
                string userCode = pnUsuarios.CreateMD5(u.email + u.senha);
                if (object.Equals(codigo, userCode))
                {
                    return View();
                }
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult AlterarSenha(LoginViewModel u)
        {
            Usuario oldU = pnUsuarios.Pesquisar(u.Email);
            if (oldU != null)
            {
                oldU.senha = u.Password;
                pnUsuarios.Alterar(oldU);
            }
            return RedirectToAction("Login", "Account");
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}