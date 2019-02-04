using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAPITemplate.Models
{
    public class SampleModel
    {
        [Key]
        public int Id { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DisplayName("Mess")]//To hide from the User
        [MinLength(3, ErrorMessage = "Min Len is {0}")]//To specify the minimum length
        public string Message { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
    }
}