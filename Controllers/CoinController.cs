using System;
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
            _postService = postService;
            _coinService = coinService;
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

        public IActionResult Topic(int coinId)
        {
            var coin = _coinService.GetById(coinId);
            var posts = _postService.GetPostsByCoin(coinId);

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

            return View();
        }

        private CoinListingModel BuildCoinListing(Post p)
        {
            throw new NotImplementedException();
        }
    }
}