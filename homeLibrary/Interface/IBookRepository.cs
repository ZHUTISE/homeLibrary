using System;
using homeLibrary.Models;

namespace homeLibrary.Interface
{
	public interface IBookRepository
	{
        ICollection<Book> GetBooks();
        Book GetBook(int id);
        Book GetBook(string title);
        bool BookExists(int id);
    }
}

