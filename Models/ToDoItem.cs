using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoItemApi.Models
{
    public class ToDoItem
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string action { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public required string description { get; set; }

        public bool completed { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string usuario {  get; set; }
    }
}
