using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenMVC.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        [TestAuthentication]
        [TestAuthorization("admin","manager")]
        [OutputCache(Duration =10)]
        public ActionResult Index()
        {
            return View();
        }
    }
}