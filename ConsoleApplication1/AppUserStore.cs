using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AppIdentityExample
{
    public class AppUserStore : UserStore<AppUser>
    {

        public AppUserStore(DbContext context) 
            : base(context)
        {
        }
    }
}