using ForumApp.Models;

namespace ForumApp.Contracts
{
    public interface IPostService
    {
        //We will use this for showing all posts
        Task<IEnumerable<PostViewModel>> GetAllAsync();
        Task AddAsync(PostViewModel model);
        Task<PostViewModel> GetByIdAsync(int id);
        Task UpdateAsync(PostViewModel model);
        Task DeleteAsync(int id);
    }
}
