using System.ComponentModel.DataAnnotations;

namespace movies.Models
{
    public class genre
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; }
    }
}
