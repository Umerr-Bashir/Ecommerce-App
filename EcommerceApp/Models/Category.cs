﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace ECommerceApp.Models
{
    [Index(nameof(Name), Name = "IX_Name_Unique", IsUnique = true)]

    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category Name is required.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Category Name must be between 3 and 30 characters.")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; }

        public bool IsActive { get; set; }

        //public ICollection<Product> Products { get; set; }
    }
}