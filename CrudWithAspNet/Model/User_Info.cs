using System.ComponentModel.DataAnnotations;

namespace CrudWithAspNet.Model
{
    public class User_Info
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public string UpdatedBy { get; set;}

    }
}
