using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData
{
    public class tblRecipe
    {
        [Key]
        public int RecipeID { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public int WriteID { get; set; }
        public virtual tblWriter Writer { get; set; }
    }
}
