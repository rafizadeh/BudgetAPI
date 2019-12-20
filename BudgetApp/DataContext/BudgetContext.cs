using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BudgetApp.Models;
using System.Data.Entity;

namespace BudgetApp.DataContext
{
    public class BudgetContext : DbContext
    {
        public BudgetContext() : base ("BudgetContext")
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
    }
}