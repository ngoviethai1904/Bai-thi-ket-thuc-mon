using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace webtintuc.Models
{
    public class tintucContext: DbContext
    {      
            public tintucContext() : base("webtintuc")
            { }
            public DbSet<tacgia> tacgia { get; set; }
            public DbSet<tintuc> tintucs { get; set; }   
    }
}