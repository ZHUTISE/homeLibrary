using homeLibrary.Models;

namespace homeLibrary.Interface;

public interface IFormRepository
{
    ICollection<Form> GetForms();
}