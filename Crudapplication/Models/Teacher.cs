using System.ComponentModel.DataAnnotations;

namespace Crudapplication.Models
{
    public class Teacher
    {
        [Key]
        public int tId { get; set; }

        [Required]
        public string Teachername { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]

        public string Teacheremail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Teacherpassword { get; set; }

        [Required]
        public string Teachersubject { get; set; }
    }
}
