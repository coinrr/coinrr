using System;
using System.Collections.Generic;
using System.Linq;
using Coinrr.EntityModel;
using Coinrr.Models.Post;
using Coinrr.Models.Reply;
using Coinrr.Services;
using Microsoft.AspNetCore.Mvc;

namespace Coinrr.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
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