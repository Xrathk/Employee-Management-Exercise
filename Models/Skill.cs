using System;
using System.ComponentModel.DataAnnotations;

namespace IndeavorTest.Models
{
    public class Skill 
    {
        public int Id { get; set; } // Primary Key

        [StringLength(100, MinimumLength = 1)]
        [Required]
        public string Name { get; set; } // Skill name

        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; } // Creation time

        [StringLength(1000, MinimumLength = 10)]
        [Required]
        public string Description { get; set; } // Skill description

    }

}
