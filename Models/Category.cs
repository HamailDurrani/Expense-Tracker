﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; } = default!;

        [Column(TypeName = "NVARCHAR(50)")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "NVARCHAR(50)")]
        public string Type { get; set; } = "Expense";

        [NotMapped]
        public string? TitleWithIcon
        {
            get { return this.Icon + " " + this.Title; }
        }
    }
}