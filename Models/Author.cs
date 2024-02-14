using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TEST
{
    public class Author
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [MaxLength(100)]
        public string name { get; set; }

        [ForeignKey("AuthorID")]
        public List<AuthorBook> books { get; set; }
    }
}