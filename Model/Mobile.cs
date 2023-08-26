﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileSalesExtraedgeassignment.Model
{
    [Table("Mobile")]
    public class Mobile
    {
        [Key]
        public int MobileId { get; set; }
        public string? Model { get; set; }
        public string? MobileDescription { get; set; }
        public int MobilePrice { get; set; }
        public int BrandId { get; set; }
    }
}
