using Microsoft.AspNet.Identity.EntityFramework;

namespace AppIdentityExample
{
    public class MyDbContext : IdentityDbContext<AppUser>
    {
        public MyDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }
    }
}