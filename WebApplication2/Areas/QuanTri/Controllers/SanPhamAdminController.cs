using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models.CSDL;


namespace WebApplication2.Areas.QuanTri.Controllers
{
    public class SanPhamAdminController : Controller
    {
        // GET: QuanTri/SanPhamAdmin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult thongkesp()
        {
            return View();
        }


    }
}