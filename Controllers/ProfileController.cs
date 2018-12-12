using Coinrr.EntityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Coinrr.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IUploadService _uploadService;
        private readonly IApplicationUserService _userService;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProfileController(UserManager<ApplicationUser> userManager, IApplicationUserService userService, IUploadService uploadService)
        {
            _userManager = userManager;
            _userService = userService;
            _uploadService = uploadService;
        }

        public IActionResult Detail(string id)
        {

        }

    }
}