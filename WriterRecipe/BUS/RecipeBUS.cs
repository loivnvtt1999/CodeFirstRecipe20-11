using DAL;
using ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class RecipeBUS
    {
        QuanLyRecipe db = new QuanLyRecipe();
        public List<tblRecipe> getAllRecipe()
        {
            return db.tblRecipes.ToList();
        }
        public int AddRecipe(tblRecipe r)
        {
            tblRecipe reptk = db.tblRecipes.Where(x => x.RecipeID == r.RecipeID).FirstOrDefault();
            if (reptk != null)
                return 0;
            db.tblRecipes.Add(r);
            db.SaveChanges();
            return 1;
        }
        public int DeleteRecipe(int ID)
        {
            tblRecipe reptk = db.tblRecipes.Where(x => x.RecipeID == ID).FirstOrDefault();
            if (reptk == null)
                return 0;
            db.tblRecipes.Remove(reptk);
            db.SaveChanges();
            return 1;
        }
        public tblRecipe getRecipe(int ID)
        {
            return db.tblRecipes.Where(x => x.RecipeID == ID).FirstOrDefault();
        }
        public int UpdateRecipe(tblRecipe r)
        {
            tblRecipe rtk = db.tblRecipes.Where(x => x.RecipeID == r.RecipeID).FirstOrDefault();
            if (rtk == null)
                return 0;
            rtk.Title = r.Title;
            rtk.Content = r.Content;
            db.SaveChanges();
            return 1;
        }
    }
}
