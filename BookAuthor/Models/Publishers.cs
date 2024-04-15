using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookAuthor.Models
{
    public class Publishers
    {
        [Key]
        public int PublisherID { get; set; }
        public string? Name { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
