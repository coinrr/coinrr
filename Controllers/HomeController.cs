using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Coinrr.Models;
using Coinrr.Models.Home;
using Coinrr.Services;
using Coinrr.Models.Post;
using Coinrr.EntityModel;
using Coinrr.Models.Coin;

namespace Coinrr.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postService;
        public HomeController(IPostService postService)
        {
            _postService = postService;
        }

        public IActionResult Index()
        {
            var model = BuildHomeIndexModel();
            return View(model);
        }

        private HomeIndexModel BuildHomeIndexModel()
        {
            var latestPosts = _postService.GetLatestPosts(10);

            var posts = latestPosts.Select(p => new PostListingModel 
            {
                Id = p.Id,
                Title = p.Title,
                AuthorName = p.User.Email,
                AuthorId = p.User.Id,
                DatePosted = p.Created.ToString(),
                RepliesCount = p.Replies.Count(),
                Coin = GetCoinListingForPost(p)
            });

            return new HomeIndexModel
            {
                LatestPosts = posts,
                SearchQuery = ""
            };
        }
 
        private CoinListingModel GetCoinListingForPost(Post p)
        {
            var coin = p.Coin;

            return new CoinListingModel 
            {
                Id = coin.Id,
                Name = coin.Name,
                Symbol = coin.Symbol,
                ImageUrl = coin.ImageUrl
            };
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
