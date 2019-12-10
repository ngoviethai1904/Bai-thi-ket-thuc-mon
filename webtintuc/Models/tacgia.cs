using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace webtintuc.Models
{
    public class tacgia
    {
        [ScaffoldColumn(false)]
        public int tacgiaID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string TenTG { get; set; }
        public virtual ICollection<tintuc> Tintucs { get; set; }
        public string Email { get; set; }
    }
}