using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData
{
    public class tblWriter
    {
        [Key]
        public int WriterID { get; set; }
        public String WriterName { get; set; }
        public virtual List<tblRecipe> Recipes { get; set; }
    }
}
