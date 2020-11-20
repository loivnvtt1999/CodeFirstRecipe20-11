using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WriterRecipe.Models;

namespace WriterRecipe.Controllers
{
    public class WriterController : Controller
    {
        XuLyWriter xuLyWriter = new XuLyWriter();
        // GET: Writer
        public PartialViewResult AllWriterPart()
        {
            return PartialView(xuLyWriter.getAllWriterXuLyModel());
        }
        public ActionResult getRecipewithWriter(int ID)
        {
            return View(xuLyWriter.getAllRecipesWithWriterXuLyModel(ID));
        }
    }
}