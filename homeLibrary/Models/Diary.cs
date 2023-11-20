using System;
namespace homeLibrary.Models
{
	public class Diary
	{
        public int Id { get; set; }
        public Book Book { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
    }
}

