using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using demo.Models;

namespace demo.Context
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}