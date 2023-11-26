using homeLibrary.Data;
using homeLibrary.Interface;
using homeLibrary.Models;

namespace homeLibrary.Repository;

public class VolumeSetRepository : IVolumeSetRepository
{
    private readonly DataContext _context;

    public VolumeSetRepository(DataContext context)
    {
        _context = context;
    }
    
    public ICollection<VolumeSet> GetVolumeSets()
    {
        return _context.VolumeSet.OrderBy(p => p.Id).ToList();
    }
}