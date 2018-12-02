using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coinrr.Data;
using Coinrr.EntityModel;
using Microsoft.EntityFrameworkCore;

namespace Coinrr.Services
{
    public class CoinService : ICoinService
    {
        private readonly ApplicationDbContext _context;

        public CoinService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Create(Coin coin)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int coinId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Coin> GetAll()
        {
            return _context.Coins
                .Include(c => c.Posts);
        }

        public Coin GetById(int id)
        {
            return _context.Coins.Where(c => c.Id == id)
                .Include(c => c.Posts).ThenInclude(p => p.User)
                .Include(c => c.Posts).ThenInclude(p => p.Replies).ThenInclude(r => r.User)
                .FirstOrDefault();
        }

        public Task UpdateCoinDescription(int coinId, string newDescription)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateCoinName(int coinId, string newName)
        {
            throw new System.NotImplementedException();
        }
    }
}