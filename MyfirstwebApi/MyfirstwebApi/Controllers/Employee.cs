using System.ComponentModel.DataAnnotations.Schema;
namespace MyfirstwebApi.Controllers
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [Column(TypeName ="varchar(50)")]
        public string? Name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Address { get; set; }

    }
}
