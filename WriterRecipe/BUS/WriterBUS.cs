using DAL;
using ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class WriterBUS
    {
        QuanLyRecipe db = new QuanLyRecipe();
        public List<tblWriter> getAllWriter()
        {
            return db.tblWriters.ToList();
        }
        public List<tblRecipe> getRecipewithWriter(int ID)
        {
            return db.tblRecipes.Where(x => x.WriteID == ID).ToList();
        }
        public int AddWriter(tblWriter writer)
        {
            tblWriter writertk = db.tblWriters.Where(x => x.WriterID == writer.WriterID).FirstOrDefault();
            if (writertk != null)
                return 0;
            db.tblWriters.Add(writer);
            db.SaveChanges();
            return 1;
        }
        public int DeleteWriter(int ID)
        {
            tblWriter writertk = db.tblWriters.Where(x => x.WriterID == ID).FirstOrDefault();
            if (writertk == null)
                return 0;
            db.tblWriters.Remove(writertk);
            db.SaveChanges();
            return 1;
        }
        public int UpdateWriter(tblWriter w)
        {
            tblWriter writertk = db.tblWriters.Where(x => x.WriterID == w.WriterID).FirstOrDefault();
            if (writertk == null)
                return 0;
            writertk.WriterName = w.WriterName;
            db.SaveChanges();
            return 1;
        }
        public tblWriter getWriter(int ID)
        {
            return db.tblWriters.Where(x => x.WriterID == ID).FirstOrDefault();
        }
    }
}
