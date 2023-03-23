using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenHuuNhan_2011065282.Models
{
    public class Category
    {
        public byte ID { get; set; }
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
    }
}