using homeLibrary.Models;

namespace homeLibrary.Interface;

public interface IStatusRepository
{
    ICollection<Status> GetStatuses();
}