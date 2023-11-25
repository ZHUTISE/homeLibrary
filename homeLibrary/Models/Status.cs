using System;
namespace homeLibrary.Models
{
	public class Status
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public ICollection<Book> Book { get; set; }
		public DateTime Created { get; set; }
    }
}

