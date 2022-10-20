using PracticeMVCLOGIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeMVCLOGIN.Controllers
{
    public class LoginController : Controller
    {
        PracLoginDBEntities db = new PracLoginDBEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(user u)
        {
            if(ModelState.IsValid==true)
            {
                var data = db.users.Where(model => model.username == u.username && model.password == u.password).FirstOrDefault();
                if(data==null)
                {
                    ViewBag.message = "Login Failed";
                }
                else
                {
                    Session["message"] = u.username;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "login");
        }
    }
}