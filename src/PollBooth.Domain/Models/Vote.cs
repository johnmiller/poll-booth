using System.ComponentModel.DataAnnotations;

namespace PollBooth.Domain.Models
{
    public class Vote
    {
        public int Id { get; set; }

        [Required]
        public int CastBallotId { get; set; }

        public int IssueId { get; set; }

        public int IssueChoiceId { get; set; }
    }
}