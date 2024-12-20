using Microsoft.AspNetCore.Identity;

namespace Hospital.Utilities
{
    internal class ApplcationUser : IdentityUser
    {
        public string UserName { get; set; }
        public string EmailTokenProvider { get; set; }
    }
}