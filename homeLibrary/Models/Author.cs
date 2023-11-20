using System;
namespace homeLibrary.Models
{
	public class Author
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string? MiddleName { get; set; }
		public string LastName { get; set; }
		public ICollection<BookAuthor> BookAuthor { get; set; }
        public DateTime Created { get; set; }
    }
}

