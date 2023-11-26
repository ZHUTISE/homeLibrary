using homeLibrary.Models;

namespace homeLibrary.Interface;

public interface IVolumeSetRepository
{
    ICollection<VolumeSet> GetVolumeSets();
}