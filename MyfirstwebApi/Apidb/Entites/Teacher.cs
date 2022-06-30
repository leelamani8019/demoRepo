using System.ComponentModel.DataAnnotations.Schema;

namespace Apidb.Entites
{
    public class Teacher
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Address { get; set; }
        public ICollection<Classes> classes { get; set; }
    }
}
