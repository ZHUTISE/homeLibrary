using System;
namespace homeLibrary.Models
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string? ISBN { get; set; }
		public ICollection<BookAuthor> BookAuthor { get; set; }
        public int? CollectionId { get; set; }
        public CollectionMap? Collection { get; set; }
        public int? FormId { get; set; }
        public BookForm? Form { get; set; }
        public DateTime Created { get; set; }
    }
}
