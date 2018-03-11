using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class DangnhapController : Controller
    {
        // GET: Dangnhap
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult login()
        {
            return View();
        }
    }
}