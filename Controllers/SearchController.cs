using System;
using System.Linq;
using Coinrr.EntityModel;
using Coinrr.Models.Coin;
using Coinrr.Models.Post;
using Coinrr.Models.Search;
using Coinrr.Services;
using Microsoft.AspNetCore.Mvc;

namespace Coinrr.Controllers
{
    public class SearchController : Controller
    {
        private readonly IPostService _postService;
        public SearchController(IPostService postService)
        {
            _postService = postService;
        }

        public IActionResult Results(string searchQuery)
        {
            var posts = _postService.GetFilteredPosts(searchQuery);
            var areNoResults = (!string.IsNullOrEmpty(searchQuery) && !posts.Any());

            var postListings = posts.Select(post => new PostListingModel 
            {
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorName = post.User.UserName,
                Title = post.Title,
                DatePosted = post.Created.ToString(),
                RepliesCount = post.Replies.Count(),
                Coin = BuildCoinList(post)
            });

            var model = new SearchResultModel
            {
                Posts = postListings,
                SearchQuery = searchQuery,
                EmptySearchResults = areNoResults
            };

            return View(model);
        }

        private CoinListingModel BuildCoinList(Post post)
        {
            var coin = post.Coin;

            return new CoinListingModel
            {
                Id = coin.Id,
                ImageUrl = coin.ImageUrl,
                Name = coin.Name,
                Description = coin.Description
            };
        }

        [HttpPost]
        public IActionResult Search(string searchQuery)
        {
            return RedirectToAction("Results", new { searchQuery });
        }


    }
}