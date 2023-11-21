using System;
namespace homeLibrary.Models
{
	public class Author
	{
		public int Id { get; set; }
		public string FMLName { get; set; }
		public ICollection<BookAuthor> BookAuthor { get; set; }
        public DateTime Created { get; set; }
    }
}

