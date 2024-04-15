using System.Text.Json.Serialization;

namespace BookAuthor.Models
{
    public class BookAuthors
    {
        public int ID { get; set; }

        public int BookID { get; set; }
        [JsonIgnore]
        public Book? Book { get; set; }

        public int AuthorID { get; set; }
        [JsonIgnore]
        public Author? Author { get; set; }
    }
}
