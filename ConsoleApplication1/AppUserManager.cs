using Microsoft.AspNet.Identity;

namespace AppIdentityExample
{
    public class AppUserManager : UserManager<AppUser>
    {
        public AppUserManager(AppUserStore store)
            : base(store)
        {
        }
    }
}