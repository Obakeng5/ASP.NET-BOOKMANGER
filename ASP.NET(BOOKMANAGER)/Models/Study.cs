using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ASP.NET_BOOKMANAGER_.Models
{
    public class Study
    {
        [Key]
        public int StudyId { get; set; }
        [Display(Name = "Author's Name")]
        public string? AuthorName { get; set; }
        public string? Univer { get; set; }
        public string? Course { get; set; }
        public decimal CCost { get; set; }
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
