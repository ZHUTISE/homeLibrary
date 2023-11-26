using homeLibrary.Data;
using homeLibrary.Interface;
using homeLibrary.Models;

namespace homeLibrary.Repository;

public class AuthorRepository : IAuthorRepository
{
    private readonly DataContext _context;

    public AuthorRepository(DataContext context)
    {
        _context = context;
    }
    
    public ICollection<Author> GetAuthors()
    {
        return _context.Author.OrderBy(p => p.Id).ToList();
    }
}