using System.ComponentModel.DataAnnotations.Schema;
namespace Apidb.Entites
{
    public class Classes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string? Name { get; set; }
        [Column(TypeName = "Varchar(50)")]

        public Teacher Teacher { get; set; }
    }
}
