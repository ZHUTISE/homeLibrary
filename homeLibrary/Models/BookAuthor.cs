using System;
namespace homeLibrary.Models
{
	public class BookAuthor
	{
		public int BookId { get; set; }
        public int AuthorId { get; set; }
        public string? Book { get; set; }
        public string? Author { get; set; }
        public Book _Book { get; set; }
		public Author _Author { get; set; }
		public DateTime Created { get; set; }
	}
}

