using Reddit.Models;

namespace Reddit.Repositories
{
    public interface ICommunityRepository
    {
        public Task<PagedList<Community>> GetCommunities(int pageNumber, int pageSize, string? searchTerm, string? SortTerm, bool? isAscending = true);
    }
}
