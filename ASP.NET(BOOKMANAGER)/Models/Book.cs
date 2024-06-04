using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_BOOKMANAGER_.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? AuthorName { get; set; }
        public decimal Wri_IN { get; set; }
        public decimal Bcost { get; set; }
        public decimal Wcost { get; set; }
        public int Sold { get; set; }

        //Navigation Area
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
