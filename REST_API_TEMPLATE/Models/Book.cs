using System.ComponentModel.DataAnnotations;

namespace REST_API_TEMPLATE.Models
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        public string? Description { get; set; }
        public Genre? Genre { get;set; }
        public string? Publisher { get; set; }
        public string? ISBN { get; set; }
        public double? Rating { get; set; }
        public DateTime ReleaseDate { get; set; }

        // One-to-many relation with author
        public Guid? AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
