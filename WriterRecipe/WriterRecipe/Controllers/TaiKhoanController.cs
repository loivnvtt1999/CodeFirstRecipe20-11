using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WriterRecipe.Models;

namespace WriterRecipe.Controllers
{
    public class TaiKhoanController : Controller
    {
        // GET: TaiKhoan
        public ActionResult DangKy()
        {
            return View();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(TaiKhoan tk)
        {
            List<TaiKhoan> lstTK;
            if (Session["listTaiKhoan"] == null)
            {
                return RedirectToAction("DangNhap", "TaiKhoan");
            }
            else
            {
                lstTK = (List<TaiKhoan>)Session["listTaiKhoan"];
                foreach (var item in lstTK)
                {
                    if (item.tendn == tk.tendn && item.matkhau == tk.matkhau)
                    {

                        Session["tendn"] = item.tendn;
                        return RedirectToAction("Index", "Recipe");

                    }
                }
                return View(tk);
            }
        }
        public PartialViewResult DangNhapPart()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult DangKy(TaiKhoan tk)
        {
            if (ModelState.IsValid)
            {
                List<TaiKhoan> lstTK;
                if (Session["listTaiKhoan"] == null)
                {
                    lstTK = new List<TaiKhoan>();
                }
                else
                {
                    lstTK = (List<TaiKhoan>)Session["listTaiKhoan"];
                }
                //Kiem tra du lieu
                foreach (var item in lstTK)
                {
                    if (item.tendn == tk.tendn)
                    {
                        Session["trungdn"] = "Tên đăng nhập đã tồn tại";
                        return View(tk);
                    }
                }
                lstTK.Add(tk);
                Session["listTaiKhoan"] = lstTK;
                Session["tendn"] = tk.tendn;
                return RedirectToAction("Index", "Recipe");
            }
            return View(tk);
        }
        public ActionResult DangXuat()
        {
            Session.Remove("tendn");
            return RedirectToAction("Index", "Recipe");
        }
        public PartialViewResult DangXuatPart()
        {
            return PartialView();
        }
        public PartialViewResult DangKyPart()
        {
            return PartialView();
        }
    }
}