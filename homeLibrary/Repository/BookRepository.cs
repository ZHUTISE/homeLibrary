using homeLibrary.Data;
using homeLibrary.Interface;
using homeLibrary.Models;

namespace homeLibrary.Repository
{
    public class BookRepository : IBookRepository
	{
		private readonly DataContext _context;

		public BookRepository(DataContext context)
		{
			_context = context;
		}
		
		public ICollection<Book> GetBooks()
		{
			return _context.Book.OrderBy(p => p.Id).ToList();
		}

        public bool BookExists(int id)
        {
            return _context.Book.Any(p => p.Id == id);
        }

        public Book GetBook(int id)
        {
            return _context.Book.Where(p => p.Id == id).FirstOrDefault();
        }

        public Book GetBook(string title)
        {
            return _context.Book.Where(p => p.Title == title).FirstOrDefault();
        }
        
	}
}

