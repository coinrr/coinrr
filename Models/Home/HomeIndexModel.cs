using System.Collections.Generic;
using Coinrr.Models.Post;

namespace Coinrr.Models.Home
{
    public class HomeIndexModel
    {
        public IEnumerable<PostListingModel> LatestPosts { get; set; }
        public string SearchQuery { get; set; }
    }
}