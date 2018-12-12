using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Coinrr.EntityModel;

namespace Coinrr.Services
{
    public interface IApplicationUserService
    {
        ApplicationUser GetById(string id);
        IEnumerable<ApplicationUser> GetAll();
        Task SetProfielImage(string id, Uri uri);
        Task IncrementRating(string id, Type type);
    }
}