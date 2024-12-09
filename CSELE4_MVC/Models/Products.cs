﻿using System.CodeDom;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSELE4_MVC.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public byte[] Content { get; set; }

        public Products()
        {
            
        }

        [NotMapped]
        [Display(Name = "Product Image")]
        public IFormFile? FormFile { get; set; }


    }
}
