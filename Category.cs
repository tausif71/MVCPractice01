using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace MVCPractice01.Models
{
   public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public int Order { get; set; }
        public int? age { get; set; }    
        public string Description { get; set; }
    }
}