using System.ComponentModel.DataAnnotations;

namespace ToDoItemApi.Models
{
    public class ToDoItem_User
    {
        [Key]
        public int id { get; set; }

        public int id_todoitem { get; set; }

        public int id_user { get; set; }
    }
}
