using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using WebApplication2.Models.CSDL;

namespace WebApplication2.Controllers
{
    public class trangchuController : Controller
    {
        // GET: trangchu
     
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TrangChu()
        {
            ViewBag.TenDM ="danh sach SP";
            var model = new SanPhamF().DSSanPham.Take(8).ToList();
            return View("TrangChu",model);
        }

        public ActionResult Trangchu1()
        {
            ViewBag.TenDM = "danh sach SP";
            var model = new SanPhamF().DSSanPham.Take(8).ToList();
            return View("TrangChu", model);
        }






    }
}