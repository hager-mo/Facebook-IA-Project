using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Facebook1.Models
{
    public class Account:DbContext
    {
        public DbSet<User> users { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}