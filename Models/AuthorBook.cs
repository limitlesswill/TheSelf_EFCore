using Microsoft.EntityFrameworkCore;

namespace TEST
{
    [PrimaryKey("AuthorID","BookID")]
    public class AuthorBook
    {
        public DateTime? edition { get; set; }
    }
}
