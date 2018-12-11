using System;
using System.Collections.Generic;
using System.Linq;
using Coinrr.EntityModel;
using Coinrr.Models.Coin;
using Coinrr.Models.Post;
using Coinrr.Services;
using Microsoft.AspNetCore.Mvc;

namespace Coinrr.Controllers
{
    public class CoinController : Controller
    {
        private readonly ICoinService _coinService;
        private readonly IPostService _postService;
        public CoinController(ICoinService coinService, IPostService postService)
        {
            _coinService = coinService;
            _postService = postService;
        }

        public IActionResult Index()
        {
            var coins = _coinService.GetAll()
                .Select(coin => new CoinListingModel
                {
                    Id = coin.Id,
                    Name = coin.Name,
                    Description = coin.Description,
                    ImageUrl = coin.ImageUrl
                });

            var model = new CoinIndexModel
            {
                CoinList = coins
            };

            return View(model);
        }

        public IActionResult Topic(int id, string searchQuery)
        {
            var coin = _coinService.GetById(id);
            var posts = new List<Post>();

            posts = _postService.GetFilteredPosts(coin, searchQuery).ToList();

            var postListings = posts.Select(p => new PostListingModel 
            {
                Id = p.Id,
                Title = p.Title,
                AuthorName = p.User.Email,
                AuthorId = p.User.Id,
                DatePosted = p.Created.ToString(),
                RepliesCount = p.Replies.Count(),
                Coin = BuildCoinListing(p)
            });
            
            var model = new CoinTopicModel
            {
                Posts = postListings,
                Coin = BuildCoinListing(coin)
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Search(int id, string searchQuery)
        {
            return RedirectToAction("Topic", new { id, searchQuery });
        }
        private CoinListingModel BuildCoinListing(Post p)
        {
            var coin = p.Coin;
            return BuildCoinListing(coin);
        }
        private CoinListingModel BuildCoinListing(Coin coin)
        {
            return new CoinListingModel
            {
                Id = coin.Id,
                Name = coin.Name,
                Symbol = coin.Symbol,
                Description = coin.Description,
                ImageUrl = coin.ImageUrl
            };
        }
    }
}