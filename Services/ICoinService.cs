using System.Collections.Generic;
using System.Threading.Tasks;
using Coinrr.EntityModel;

namespace Coinrr.Services
{
    public interface ICoinService
    {
         Coin GetById(int coinId);
         IEnumerable<Coin> GetAll();
         
         Task Create(Coin coin);
         Task Delete(int coinId);
         Task UpdateCoinName(int coinId, string newName);
         Task UpdateCoinDescription(int coinId, string newDescription);

    }
}