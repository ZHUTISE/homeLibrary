using System;
namespace homeLibrary.Models
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string? ISBN { get; set; }
		public Volume? Volume { get; set; }
		public Status Status { get; set; }
        public Form Form { get; set; }
        public ICollection<BookAuthor> BookAuthor { get; set; }
        public DateTime Created { get; set; }
    }
}
