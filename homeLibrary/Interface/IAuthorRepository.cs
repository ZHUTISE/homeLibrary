using homeLibrary.Models;

namespace homeLibrary.Interface
{
    public interface IAuthorRepository
    {
        ICollection<Author> GetAuthors();
    }
}