using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PollBooth.Domain.Models
{
    public class Vote
    {
        public int Id { get; set; }

        [Required]
        public int CastBallotId { get; set; }

        public int IssueId { get; set; }
        
        public Issue Issue { get; set; }

        public IssueChoice IssueChoice { get; set; }

        public int IssueChoiceId { get; set; }
    }
}