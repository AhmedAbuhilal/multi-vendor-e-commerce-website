﻿using MVC_Project.Models.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Project.Models.Order
{
    public class Invoice
    {
        public int Id { get; set; }
        public required string InvoiceNumber { get; set; }

        [Column(TypeName ="money")]
        public decimal TotalPaid { get; set; }
        public string Currency { get; set; }

        [ForeignKey("Account")]
        public int AccountId { get; set; }

        public virtual Account? Account { get; set; }

        [ForeignKey("Order")]
        public int? OrderId { get; set; }

        public virtual Order? Order { get; set; }

        public DateTime AddedAt { get; set; } = DateTime.Now;
    }
}
