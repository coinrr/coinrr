using Coinrr.EntityModel;
using Coinrr.Models.ApplicationUser;
using Coinrr.Services;
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

        public async System.Threading.Tasks.Task<IActionResult> DetailAsync(string id)
        {
            var user = _userService.GetById(id);
            var userRoles = await _userManager.GetRolesAsync(user);

            var model = new ProfileModel()
            {
                UserId = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                ProfileImageUrl = user.ProfileImageUrl,
                MemberSince = user.MemberSince,
                IsAdmin = userRoles.Contains("Admin")
            };

            return View(model);
        }

    }
}