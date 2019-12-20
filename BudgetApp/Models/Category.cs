using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BudgetApp.Models
{
    public class Category
    {
        public enum CategoryType
        {
            Income = 0,
            Expense = 1
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public CategoryType Type { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}