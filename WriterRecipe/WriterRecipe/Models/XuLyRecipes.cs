using BUS;
using ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WriterRecipe.Models
{
    public class XuLyRecipes
    {
        RecipeBUS rBUS = new RecipeBUS();
        public List<tblRecipe> getAllRecipeXuLyModel()
        {
            return rBUS.getAllRecipe();
        }
        public int AddRecipe(tblRecipe r)
        {
            return rBUS.AddRecipe(r);
        }
        public int DeleteRecipe(int ID)
        {
            return rBUS.DeleteRecipe(ID);
        }
        public tblRecipe getRecipe(int ID)
        {
            return rBUS.getRecipe(ID);
        }
        public int EditRecipe(tblRecipe r)
        {
            return rBUS.UpdateRecipe(r);
        }
    }
}