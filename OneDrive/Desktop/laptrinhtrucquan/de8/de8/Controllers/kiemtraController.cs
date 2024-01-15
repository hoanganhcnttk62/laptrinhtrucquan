using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using de8.Models;
namespace de8.Controllers
{
    public class kiemtraController : Controller
    {
        QLBanChauCanhEntities  db = new QLBanChauCanhEntities();
        // GET: kiemtra
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult menu()
        {
            List<PhanLoaiPhu> listphanlhoaiphu = db.PhanLoaiPhus.ToList();
            return PartialView("header", listphanlhoaiphu);

        }
        public ActionResult danhsasch()
        {
            List<SanPham> listsanpham = db.SanPhams.ToList();
            return PartialView("main", listsanpham);

        }
        public ActionResult lietke(string CatId)
        {
            List<SanPham> sanPhams = db.SanPhams.Where(sp => sp.MaPhanLoaiPhu == CatId).ToList();
            return PartialView("main", sanPhams);
        }
    }
}