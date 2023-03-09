using System.ComponentModel.DataAnnotations;

namespace CrudWithAspNet.Model
{
    public class Admited_Student_Info
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string First_Name { get; set; }
        [Required]
        public string Last_Name { get; set; }

        [Required]
        public string Father_NID { get; set; }

        [Required]
        public string Father_Name { get; set; }
        [Required]
        public string Mother_Name { get; set; }

        [Required]
        public string Mobile_Number { get; set; }

        [Required]
        public int Class_Maintain_Id { get; set; }

        [Required]
        public int Class_Roll { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }
    }
}
