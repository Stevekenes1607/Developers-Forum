using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopersForum.ViewModels.Profile
{
    public class EditProfileModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string ExistingPhotoPath { get; set; }
        public IFormFile Photo { get; set; }
    }
}
