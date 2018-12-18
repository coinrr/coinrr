using Microsoft.AspNetCore.Http;

namespace Coinrr.Models.Coin
{
    public class AddCoinModel
    {
        public string Title { get; set; }  
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public IFormFile ImageUpload { get; set; }
    }
}