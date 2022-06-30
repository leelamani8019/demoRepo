using System.ComponentModel.DataAnnotations.Schema;

namespace Apidb.Entites
{
    public class Classroom
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
        public int Strength { get; set; }
        public int ClassroomId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Address { get; set; }
    }
}
