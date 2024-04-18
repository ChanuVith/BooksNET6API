using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BooksNET6API.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Genere { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string PublisherName { get; set; }
    }
}
