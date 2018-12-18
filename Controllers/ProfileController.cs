using System.Net.Http.Headers;
using System.Threading.Tasks;
using Coinrr.EntityModel;
using Coinrr.Models.ApplicationUser;
using Coinrr.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Coinrr.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IUploadService _uploadService;
        private readonly IApplicationUserService _userService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public ProfileController(
            UserManager<ApplicationUser> userManager, 
            IApplicationUserService userService, 
            IUploadService uploadService,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _userService = userService;
            _uploadService = uploadService;
            _configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public async Task<IActionResult> Detail(string id)
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

        [HttpPost]
        public async Task<IActionResult> UploadProfileImage(IFormFile file)
        {
            var userId = _userManager.GetUserId(User);
            
            // connect to azure storage account container
            var connectionString = _configuration.GetConnectionString("AzureStorageAccount");
            
            // get blob container
            var container = _uploadService.GetBlobContainer(connectionString, "profile-images");

            // pasrse the content disposition response header
            var contentDisposition = ContentDispositionHeaderValue.Parse(file.ContentDisposition);

            // grab the filename
            var filename = contentDisposition.FileName.Trim('"');

            // get a reference to a block blob
            var blockBlob = container.GetBlockBlobReference(filename);

            // on the block blob , upload our file <-- file uploaded to the cloud
            await blockBlob.UploadFromStreamAsync(file.OpenReadStream());

            // set the user's profile image to the uri
            await _userService.SetProfielImageAsync(userId, blockBlob.Uri);
            
            // redirect to the user's profile page
            return RedirectToAction("Detail", "Profile", new { id = userId} );

        }
    }
}