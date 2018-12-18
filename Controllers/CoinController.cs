using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Coinrr.EntityModel;
using Coinrr.Models.Coin;
using Coinrr.Models.Post;
using Coinrr.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Coinrr.Controllers
{
    public class CoinController : Controller
    {
        private readonly ICoinService _coinService;
        private readonly IPostService _postService;
        private readonly IUploadService _uploadService;
        private readonly IConfiguration _configuration;

        public CoinController(
            ICoinService coinService, 
            IPostService postService,
            IUploadService uploadService,
            IConfiguration configuration)
        {
            _coinService = coinService;
            _postService = postService;
            _uploadService = uploadService;
            _configuration = configuration;
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
        
        public IActionResult Create()
        {
            var model = new AddCoinModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddCoin(AddCoinModel model)
        {
            var imageUri = "/images/users/default.png";

            if (model.ImageUpload != null )
            {
                var blockBlob = await UploadCoinImage(model.ImageUpload);
                imageUri = blockBlob.Uri.AbsoluteUri;
            }

            var coin = new Coin
            {
                Name = model.Title,
                Description = model.Description,
                ImageUrl = imageUri
            };

            await _coinService.Create(coin);
            return RedirectToAction("Index", "Coin");
        }

        private async Task<CloudBlockBlob> UploadCoinImage(IFormFile file)
        {
            // connect to azure storage account container
            var connectionString = _configuration.GetConnectionString("AzureStorageAccount");
            
            // get blob container
            var container = _uploadService.GetBlobContainer(connectionString);

            // pasrse the content disposition response header
            var contentDisposition = ContentDispositionHeaderValue.Parse(file.ContentDisposition);

            // grab the filename
            var filename = contentDisposition.FileName.Trim('"');

            // get a reference to a block blob
            var blockBlob = container.GetBlockBlobReference(filename);

            // on the block blob , upload our file <-- file uploaded to the cloud
            await blockBlob.UploadFromStreamAsync(file.OpenReadStream());

            return blockBlob;

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