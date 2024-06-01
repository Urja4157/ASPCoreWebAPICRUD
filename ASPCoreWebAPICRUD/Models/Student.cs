using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPCoreWebAPICRUD.Models
{
    public partial class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string StudentName { get; set; }

        [MaxLength(50)]
        public string StudentGender { get; set; }

        public int Age { get; set; }

        public int Standard { get; set; }

        [MaxLength(255)]
        public string FatherName { get; set; }
    }
}
