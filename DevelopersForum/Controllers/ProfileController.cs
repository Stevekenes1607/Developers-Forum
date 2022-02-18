using DevelopersForum.Interfaces;
using DevelopersForum.Models;
using DevelopersForum.ViewModels.Profile;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopersForum.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUsers> _userManager;
        private readonly IApplicationUser _userService;
        private readonly IUpload _uploadService;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IApplicationUser _applicationUser;

        public ProfileController(UserManager<ApplicationUsers> userManager, 
            IApplicationUser userService, IApplicationUser applicationUser,
            IUpload uploadService, IHostingEnvironment hostingEnvironment)
        {
            _userManager = userManager;
            _userService = userService;
            _uploadService = uploadService;
            _hostingEnvironment = hostingEnvironment;
            _applicationUser = applicationUser;
        }

        public IActionResult Detail(string id)
        {
            var user = _userService.GetById(id);
            var userRoles = _userManager.GetRolesAsync(user).Result;

            var model = new ProfileModel
            {
                UserId = user.Id,
                UserName = user.UserName,
                UserRating = user.Rating.ToString(),
                Email = user.Email,
                ProfileImageUrl = user.ProfileImageUrl,
                MemberSince = user.MemberSince,
                IsAdmin = userRoles.Contains("Admin"),
            };
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var users = _userService.GetAll()
                .OrderByDescending(user => user.Rating)
                 .Select(user => new ProfileModel
                 {
                     UserName = user.UserName,
                     Email = user.Email,
                     ProfileImageUrl = user.ProfileImageUrl,
                     MemberSince = user.MemberSince,
                     UserRating = user.Rating.ToString()
                 });

            var model = new ProfileListModel
            {
                Profiles = users
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UploadPhoto(EditProfileModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUsers user = await _userManager.FindByIdAsync(model.Id);
                if (model.Photo != null)
                {
                    if (model.ExistingPhotoPath != null)
                    {
                        string filePath = Path.Combine(_hostingEnvironment.WebRootPath,
                            "images/users", model.ExistingPhotoPath);
                        System.IO.File.Delete(filePath);
                    }
                    user.ProfileImageUrl = BuildFileUpload(model);
                }
                await _userManager.UpdateAsync(user);

                return RedirectToAction("Detail");
            }

            return View();
        }

        private string BuildFileUpload(EditProfileModel model)
        {
            string uniqueFileName = null;
            if (model.Photo != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images/users");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
            }

            return uniqueFileName;
        }
    }
}
