using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using PollBooth.Domain.Models;

namespace PollBooth.Domain.Repositories
{
    public class PollBoothContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Ballot> Ballots { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<IssueChoice> IssueChoices { get; set; }
        public DbSet<CastBallot> CastBallots { get; set; }
        public DbSet<Vote> Votes { get; set; }

        public PollBoothContext()
            : base("DefaultConnection")
        {
        }
    }
}