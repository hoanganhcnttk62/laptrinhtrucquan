using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime;
using de2.Models;


namespace de2.Controllers
{
    public class ktrController : Controller
    {
        // GET: ktr
        QLBanQuanAoEntities db = new QLBanQuanAoEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult menu()
        {
            List<PhanLoaiPhu> listphanloaiphu = db.PhanLoaiPhus.ToList();
            return PartialView("main", listphanloaiphu);


        }
        public ActionResult hienthi()
        {
            List<SanPham> sanpham = db.SanPhams.ToList();
            return PartialView("main", sanpham);

        }
        public ActionResult lietke(string CatId)
        {
            List<SanPham> sanPhams = db.SanPhams.Where(sp => sp.MaPhanLoaiPhu == CatId).ToList();
            return PartialView("main", sanPhams);
        }
        public ActionResult them()
        {

            return View();
        }
        [HttpPost]
         public  ActionResult them(SanPham sp)
        {
            sp.MaPhanLoai = Request.Form["MaPLC"];
            sp.MaPhanLoaiPhu = Request.Form["MaPLP"];
            db.SanPhams.Add(sp);

            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult sua(string id)
        {
            var update = db.SanPhams.Find(id);
            return View(update);
        }
        [HttpPost]

        public ActionResult sua(SanPham sp)
        {
            var sua = db.SanPhams.Find(sp.MaSanPham);
            sua.TenSanPham = sp.TenSanPham;
            sua.MaPhanLoaiPhu = sp.Maphanloaisuacp;
            sua.MaPhanLoai = sp.Maphanloaisuac;
            sua.PhanLoaiPhu = sp.PhanLoaiPhu;
            sua.PhanLoai = sp.PhanLoai;
            sua.DonGiaBanLonNhat=sp.DonGiaBanLonNhat;
            sua.DonGiaBanNhoNhat = sp.DonGiaBanNhoNhat;
            sua.AnhDaiDien = sp.AnhDaiDien;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult xoa(string id)
        {
            var xoa = db.SanPhams.Find(id);
            db.SanPhams.Remove(xoa);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}