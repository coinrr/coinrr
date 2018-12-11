using System.Collections.Generic;
using Coinrr.Models.Post;

namespace Coinrr.Models.Coin
{
    public class CoinTopicModel
    {
        public CoinListingModel Coin { get; set; }
        public IEnumerable<PostListingModel> Posts { get; set; }
        public string SearchQuery { get; set; }
    }
}