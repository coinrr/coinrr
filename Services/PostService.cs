using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coinrr.Data;
using Coinrr.EntityModel;

namespace Coinrr.Services
{
    public class PostService : IPostService
    {
        private readonly ApplicationDbContext _context;
        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Add(Post post)
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Post> GetPostsByCoin(int coinId)
        {
            var posts = _context.Coins
                .Where(c => c.Id == coinId).First()
                .Posts;

            return posts;
        }
    }
}