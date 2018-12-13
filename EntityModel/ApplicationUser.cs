using System;
using Microsoft.AspNetCore.Identity;

namespace Coinrr.EntityModel
{
    public class ApplicationUser : IdentityUser
    {
        public string ProfileImageUrl { get; set; }
        public DateTime MemberSince { get; set; }
    }
}