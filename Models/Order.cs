using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MedicationOrders.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public virtual Provider Provider { get; set; }
        
        [Required]
        public virtual Patient Patient { get; set; }

        [Required]
        public virtual IEnumerable<OrderItem> Items { get; set; }

        [NotMapped]
        public int DaysSupply => Items.Min(x => x.DaysSupply);
    }
}
