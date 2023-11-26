using homeLibrary.Data;
using homeLibrary.Interface;
using homeLibrary.Models;

namespace homeLibrary.Repository;

public class StatusRepository : IStatusRepository
{
    private readonly DataContext _context;

    public StatusRepository(DataContext context)
    {
        _context = context;
    }
    
    public ICollection<Status> GetStatuses()
    {
        return _context.Status.OrderBy(p => p.Id).ToList();
    }
}