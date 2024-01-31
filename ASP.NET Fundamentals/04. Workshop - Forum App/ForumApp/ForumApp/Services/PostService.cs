using ForumApp.Contracts;
using ForumApp.Data;
using ForumApp.Data.Models;
using ForumApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace ForumApp.Services
{
    public class PostService : IPostService
    {
        private readonly ForumAppDbContext context;
        public PostService(ForumAppDbContext _context)
        {
            context = _context;
        }


        public async Task<IEnumerable<PostViewModel>> GetAllAsync()
        {
            return await context.Posts
                .AsNoTracking()
                .Select(p => new PostViewModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content,
                })
                .ToListAsync();
        }
        public async Task AddAsync(PostViewModel model)
        {
            Post post = new Post
            {
                Title = model.Title,
                Content = model.Content,
            };

            await context.AddAsync(post);
            await context.SaveChangesAsync();
        }

        public async Task<PostViewModel> GetByIdAsync(int id)
        {
            var post = await context.Posts.FindAsync(id);
            PostViewModel model = new PostViewModel()
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
            };
            return model;
        }

        public async Task UpdateAsync(PostViewModel model)
        {
            var post = await context.Posts.FindAsync(model.Id);
            if(post != null)
            {
                post.Title = model.Title;
                post.Content = model.Content;
            }
            await context.SaveChangesAsync();
        }
    }
}
