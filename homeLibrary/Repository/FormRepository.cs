using homeLibrary.Data;
using homeLibrary.Interface;
using homeLibrary.Models;

namespace homeLibrary.Repository;

public class FormRepository : IFormRepository
{
    private readonly DataContext _context;

    public FormRepository(DataContext context)
    {
        _context = context;
    }
    
    public ICollection<Form> GetForms()
    {
        return _context.Form.OrderBy(p => p.Id).ToList();
    }
}