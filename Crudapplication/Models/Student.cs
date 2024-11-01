using System.ComponentModel.DataAnnotations;

namespace Crudapplication.Models
{
    public class Student
    {
        [Key]
        public int studentId { get; set; }
        [Required]
        public string studentname { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string studentemail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string studentpassword { get; set; }
    }
}
