using System.Linq;
using Coinrr.Models.Coin;
using Coinrr.Services;
using Microsoft.AspNetCore.Mvc;

namespace Coinrr.Controllers
{
    public class CoinController : Controller
    {
        private readonly ICoinService _coinService;
        public CoinController(ICoinService coinService)
        {
            _coinService = coinService;
        }

        public IActionResult Index()
        {
            var coins = _coinService.GetAll()
                .Select(coin => new CoinListingModel {
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
    }
}