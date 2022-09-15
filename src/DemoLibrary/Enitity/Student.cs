using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebLibrary
{
    public class Student
    {
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Address { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Email { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public double CGPA { get; set; }
    }
}
