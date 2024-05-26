using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoItemApi.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public required string name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string usuario {  get; set; }

    }
}
