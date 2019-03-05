﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DevExpress_OData.Models
{
    [Table("Customer")]
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(12)]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }
        public decimal Balance { get; set; }
    }
}