using Microsoft.AspNet.Identity.EntityFramework;
using PollBooth.Domain.Models;

namespace PollBooth.Domain.Repositories
{
    public class PollBoothContext : IdentityDbContext<ApplicationUser>
    {
        public PollBoothContext()
            : base("DefaultConnection")
        {
        }
    }
}