﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoFoodApI.Entities
{
    [Table("Orders")]
    public class Orders
    {
        [Key]//set Primary key constraint
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Orderid { get; set; }
        [Column(TypeName = "Date")]
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "Decimal")]
        public double TotalAmount { get; set; }
     
        public int Customerid { get; set; }
        [ForeignKey("Customerid")]//set foreign key constraint
        private Customer Customer { get; set; }

        [StringLength(20)]
        public string OrderStatus { get; set; }

    }

}