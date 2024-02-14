using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TEST
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [MaxLength(100)]
        public string title { get; set; }
        [MaxLength(100)]
        public string? description { get; set; }
        [Range(0, double.MaxValue),Column(TypeName ="decimal(9,2)")]
        public double price { get; set; }
        [ForeignKey("BookID")]
        public List<AuthorBook> authors { get; set; }
    }
}
