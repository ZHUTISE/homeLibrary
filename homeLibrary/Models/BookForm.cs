using System;
namespace homeLibrary.Models
{
	public class BookForm
	{
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public string Form { get; set; }
        public DateTime Created { get; set; }
    }
}

