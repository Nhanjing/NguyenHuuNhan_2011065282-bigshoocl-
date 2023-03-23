using NguyenHuuNhan_2011065282.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenHuuNhan_2011065282.Views.ViewModels
{
    public class CourseViewModel
    {
        [Required] 
        public string Place { get; set; }

        [Required]
        [FutureData]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}