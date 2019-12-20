using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetApp.Models
{
    public enum Status
    {
        Pending = 0,
        Completed = 1,
        Canceled = 2
    }

    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string  Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [Column(TypeName ="money")]
        public decimal Value { get; set; }

        [Required]
        public string Desc { get; set; }

        [Required]
        public Status Status { get; set; }

        public User User { get; set; }

        public Category Category { get; set; }
    }
}