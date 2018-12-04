using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coinrr.EntityModel;
using Coinrr.Models.Post;
using Coinrr.Models.Reply;
using Coinrr.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Coinrr.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly ICoinService _coinService;
        private readonly UserManager<ApplicationUser> _userManager;
        public PostController(IPostService postService, ICoinService coinService, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _coinService = coinService;
            _postService = postService;
        }

        public IActionResult Index(int id)
        {
            var post = _postService.GetById(id);
            var replies = BuildPostReplies(post.Replies);

            var model = new PostIndexModel
            {
                Id = post.Id,
                Title = post.Title,
                AuthorId = post.User.Id,
                AuthorName = post.User.Email,
                AuthorImageUrl = post.User.ProfileImageUrl,
                Created = post.Created,
                PostContent = post.Content,
                Replies = replies
            };
            return View(model);
        }

        public IActionResult Create(int id)
        {
            //id is coin id
            var coin = _coinService.GetById(id);

            var model = new NewPostModel
            {
                CoinName = coin.Name,
                CoinId = coin.Id,
                CoinImageUrl = coin.ImageUrl,
                AuthorName = User.Identity.Name
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddPost(NewPostModel model)
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            var post = BuildPost(model, user);

            await _postService.Add(post);
            //TODO: Implement user rating system

            return RedirectToAction("Index", "Post", new { id = post.Id });
        }

        private Post BuildPost(NewPostModel model, ApplicationUser user)
        {
            var coin = _coinService.GetById(model.CoinId);

            return new Post 
            {
                Title = model.Title,
                Content = model.Content,
                Created = DateTime.Now,
                User = user,
                Coin = coin
            };
        }

        private IEnumerable<PostReplyModel> BuildPostReplies(IEnumerable<PostReply> replies)
        {
            return replies.Select(r => new PostReplyModel
            {
                Id = r.Id,
                AuthorId = r.User.Id,
                AuthorName = r.User.Email,
                AuthorImageUrl = r.User.ProfileImageUrl,
                Created = r.Created,
                ReplyContent = r.Content
            });
        }
    }
}