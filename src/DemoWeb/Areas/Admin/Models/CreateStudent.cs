
using DemoWebLibrary.Services;
using System.ComponentModel.DataAnnotations;

namespace DemoWeb.Areas.Admin.Models
{
    public class CreateStudent:ICreateStudent
    {
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

        private readonly StudentService _studentService;

        public async Task StudentCreate()
        {
            
           
        }

    }
}
