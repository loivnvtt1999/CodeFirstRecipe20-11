using DAL;
using ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WriterRecipe.Models;

namespace WriterRecipe.Controllers
{
    public class RecipeController : Controller
    {
        //QuanLyRecipe db = new QuanLyRecipe();
        XuLyWriter xl = new XuLyWriter();
        XuLyRecipes xuLyRecipes = new XuLyRecipes();
        // GET: Recipe
        public ActionResult Index()
        {
            return View(xuLyRecipes.getAllRecipeXuLyModel());
        }
        public ActionResult AddRecipe()
        {
            //ViewBag.WriterID = new SelectList(xl.getAllWriterXuLyModel(), "WriterID", "WriterName");
            return View();
        }
        [HttpPost]
        public ActionResult AddRecipe(tblRecipe r)
        {
            int kq= xuLyRecipes.AddRecipe(r);
            if (kq == 0)
            {
                ViewBag.TrungMa = "Mã công thức trùng";
                return View(r);
            }
            return RedirectToAction("Index", "Recipe");
        }
        public ActionResult Delete(int ID)
        {
            return View(xuLyRecipes.getRecipe(ID));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int ID)
        {
            int kq = xuLyRecipes.DeleteRecipe(ID);
            return RedirectToAction("Index", "Recipe");
        }
        public ActionResult Details(int ID)
        {
            return View(xuLyRecipes.getRecipe(ID));
        }
        public ActionResult Edit(int ID)
        {
            return View(xuLyRecipes.getRecipe(ID));
        }
        [HttpPost]
        public ActionResult Edit(tblRecipe r)
        {
            int kq = xuLyRecipes.EditRecipe(r);
            return RedirectToAction("Index", "Recipe");
        }
    }
}