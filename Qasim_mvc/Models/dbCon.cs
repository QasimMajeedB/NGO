using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Qasim_mvc.Models
{
    public class dbCon :DbContext
    {
        public dbCon() : base("con") { 
        
        }
        public DbSet<Emp> empp { set; get; }
    }
}