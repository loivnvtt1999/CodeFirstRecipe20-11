using BUS;
using ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WriterRecipe.Models
{
    public class XuLyWriter
    {
        WriterBUS wBUS = new WriterBUS();
        public List<tblWriter> getAllWriterXuLyModel()
        {
            return wBUS.getAllWriter();
        }
        public List<tblRecipe> getAllRecipesWithWriterXuLyModel(int ID)
        {
            return wBUS.getRecipewithWriter(ID);
        }
        public int AddWriterXuLyModel(tblWriter w)
        {
            return wBUS.AddWriter(w);
        }
        public int UpdateWriter(tblWriter w)
        {
            return wBUS.UpdateWriter(w);
        }
    }
}