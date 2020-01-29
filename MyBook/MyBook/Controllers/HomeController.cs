using Logic.DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBook.Controllers
{
    public class HomeController : BaseController
    {
        private IAdminLogic _adminLogic;

        public HomeController(IAdminLogic adminLogic)
        {
            this._adminLogic = adminLogic;
        }

        public ActionResult Index()
        {
            var admin = this._adminLogic.GetAdmin(1);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}