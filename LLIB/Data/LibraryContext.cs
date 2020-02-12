using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LLIB.Models;
using LLIB.Forms;
using System.Data.Entity;


namespace LLIB.Data
{
    class LLIBContext:DbContext
    {

        public LLIBContext() : base("LLIBContext")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User>Users { get; set; }
        public DbSet<Book> Books { get; set; }



    }
}
