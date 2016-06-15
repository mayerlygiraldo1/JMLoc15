using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JMLoc15.Models
{
    public class JMLoc15Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public JMLoc15Context() : base("name=JMLoc15Context")
        {
        }

        public System.Data.Entity.DbSet<JMLoc15.Models.Lines> Lines { get; set; }

        public System.Data.Entity.DbSet<JMLoc15.Models.Users> Users { get; set; }

        public System.Data.Entity.DbSet<JMLoc15.Models.UserLines> UserLines { get; set; }
    }
}
