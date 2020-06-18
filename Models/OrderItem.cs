using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MedicationOrders.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Frequency { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int DaysSupply { get; set; }

        [Required]
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
    }
}
