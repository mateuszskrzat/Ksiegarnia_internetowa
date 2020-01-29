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
        private IProductLogic _productLogic;

        public HomeController(IAdminLogic adminLogic, IProductLogic productLogic)
        {
            this._adminLogic = adminLogic;
            this._productLogic = productLogic;
        }

        public ActionResult Index()
        {
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