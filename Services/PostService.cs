using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coinrr.Data;
using Coinrr.EntityModel;
using Microsoft.EntityFrameworkCore;

namespace Coinrr.Services
{
    public class PostService : IPostService
    {
        private readonly ApplicationDbContext _context;
        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Post post)
        {
            _context.Add(post);
            await _context.SaveChangesAsync();
        }

        public Task AddReply(PostReply reply)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int postId)
        {
            throw new System.NotImplementedException();
        }

        public Task EditPostContent(int postId, string newContent)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts
                .Include(p => p.User)
                .Include(p => p.Replies).ThenInclude(r => r.User)
                .Include(p => p.Coin);
        }

        public Post GetById(int id)
        {
            return _context.Posts.Where(p => p.Id == id)
                .Include(p => p.User)
                .Include(p => p.Replies).ThenInclude(r => r.User)
                .Include(p => p.Coin)
                .First();
        }

        public IEnumerable<Post> GetFilteredPosts(Coin coin, string searchQuery)
        {
            return string.IsNullOrEmpty(searchQuery)
                ? coin.Posts
                : coin.Posts.Where(post 
                    => post.Title.Contains(searchQuery) 
                    || post.Content.Contains(searchQuery));
        }

        public IEnumerable<Post> GetLatestPosts(int n)
        {
            return GetAll().OrderByDescending(p => p.Created).Take(n);
        }

        public IEnumerable<Post> GetPostsByCoin(int coinId)
        {
            return _context.Coins
                .Where(c => c.Id == coinId).First()
                .Posts;
        }
    }
}