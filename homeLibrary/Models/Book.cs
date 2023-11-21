using System;
namespace homeLibrary.Models
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string? ISBN { get; set; }
		public ICollection<BookAuthor> BookAuthor { get; set; }
        public string? Collection { get; set; }
        public string? Form { get; set; }
        public string? Volume { get; set; }
        public DateTime Created { get; set; }
    }
}
