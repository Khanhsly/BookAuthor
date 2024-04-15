using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BookAuthor.Models 
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string? FullName { get; set; }
        [JsonIgnore]
        public ICollection<BookAuthors>? BookAuthors { get; set; }
    }
}
