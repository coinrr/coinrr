using System.Collections.Generic;
using System.Threading.Tasks;
using Coinrr.EntityModel;

namespace Coinrr.Services
{
    public interface IPostService
    {
        Post GetById(int postId);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPosts(Coin coin, string searchQuery);
        IEnumerable<Post> GetPostsByCoin(int postId);
        IEnumerable<Post> GetLatestPosts(int n);

        Task Add(Post post);
        Task Delete(int postId);
        Task EditPostContent(int postId, string newContent);
        Task AddReply(PostReply reply);
        
    }
}