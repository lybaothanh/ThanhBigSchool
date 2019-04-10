using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Course
    { 
        //rhrrhrh
        public int Id { get; set;}
        public ApplicationUser Lecterer { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DataTime DataTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
    
}