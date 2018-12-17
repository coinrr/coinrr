using System;

namespace Coinrr.Models.Reply
{
    public class PostReplyModel
    {
        public int Id { get; set; }
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }
        public bool IsAuthorAdmin { get; set; }

        public DateTime Created { get; set; }
        public string ReplyContent { get; set; }

        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }

        public int CoinId { get; set; }
        public string CoinName { get; set; }
        public string CoinImageUrl { get; set; } 
    }
}