using System;
namespace homeLibrary.Models
{
	public class CollectionMap
	{
        public int Id { get; set; }
        public Collection Collection { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int? Volume { get; set; }
        public DateTime Created { get; set; }
    }
}

