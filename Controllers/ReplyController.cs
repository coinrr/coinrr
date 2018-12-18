using System;
using System.Threading.Tasks;
using Coinrr.EntityModel;
using Coinrr.Models.Reply;
using Coinrr.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Coinrr.Controllers
{
    [Authorize]
    public class ReplyController : Controller
    {
        private readonly IPostService _postService;
        private readonly UserManager<ApplicationUser> _userManager;
        public ReplyController(IPostService postService, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _postService = postService;
        }

        public async Task<IActionResult> Create(int id)
        {
            var post = _postService.GetById(id);
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            
            var model = new PostReplyModel
            {
                PostContent = post.Content,
                PostTitle = post.Title,
                PostId = post.Id,

                AuthorName = User.Identity.Name,
                AuthorId = user.Id,
                AuthorImageUrl = user.ProfileImageUrl,
                IsAuthorAdmin = User.IsInRole("Admin"),

                CoinId = post.Coin.Id,
                CoinName = post.Coin.Name,
                CoinImageUrl = post.Coin.ImageUrl,

                Created = DateTime.Now,
            };

            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> AddReply(PostReplyModel model)
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);

            var reply = BuildReply(model, user);

            await _postService.AddReply(reply);

            return RedirectToAction("Index", "Post", new { id = model.PostId});
        }

        private PostReply BuildReply(PostReplyModel model, ApplicationUser user)
        {
            var post = _postService.GetById(model.PostId);

            return new PostReply
            {
                Post = post,
                Content = model.ReplyContent,
                Created = DateTime.Now,
                User = user
            };
        }
    }
}