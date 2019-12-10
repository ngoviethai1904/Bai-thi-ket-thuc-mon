using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace webtintuc.Models
{
    public class tintuc
    {
        [ScaffoldColumn(false)]
        public int TinID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string Noidung { get; set; }
        [Required, StringLength(1000), Display(Name = "Tintuc Description"),
        DataType(DataType.MultilineText)]
        public string Ngaygui { get; set; }
        public string Anh { get; set; }
        
        
        public int? tacgiaID { get; set; }
        public virtual tacgia Category { get; set; }
    }
}