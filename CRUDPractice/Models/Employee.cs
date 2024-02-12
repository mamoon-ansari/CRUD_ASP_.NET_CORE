using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CRUDPractice.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Full Name")]
        [Required(ErrorMessage = "Please enter Full Name")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Employee Code")]
        public string EmployeeCode { get; set; }
        [Column(TypeName = "nvarchar(100)")]

        public string Position { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }
    }
}
