using System.ComponentModel.DataAnnotations;

namespace ASP.NET_BOOKMANAGER_.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Author's Name")]
        public string? AuthorName { get; set; }
        public DateTime DoB { get; set; }
        public DateTime DoJ { get; set; }
        public string? Sex { get; set; }
        public string? Lang1 { get; set;}
        public string? Lang2 { get; set;}
        public int Salary { get; set;}
    }
}
