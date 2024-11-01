using System.ComponentModel.DataAnnotations;

namespace Crudapplication.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string AdminName { get; set; }

       [Required]
        public string AdminEmail { get; set; }

        [Required]
        public string AdminPassword { get; set; }

    }
}
