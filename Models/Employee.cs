using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IndeavorTest.Models
{
    public class Employee
    {
        public int Id { get; set; } // Primary Key

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(100, MinimumLength = 1)]
        [Required]
        public string Name { get; set; } // Employee name

        [Display(Name = "Surname")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(100, MinimumLength = 1)]
        [Required]
        public string SurName { get; set; } // Employee surname
        
        [Range(15,75)]
        [Required]
        public int Age { get; set; } // Employee Age

        [Display(Name = "Hiring Date")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; } // Employee hiring date


        public virtual ICollection<Skill> Skills { get; set; } // Employee skills

    }
}
