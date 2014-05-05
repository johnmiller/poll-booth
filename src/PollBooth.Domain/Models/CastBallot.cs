using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PollBooth.Domain.Models
{
    public class CastBallot
    {
        public int Id { get; set; }

        [Required]
        public int BallotId { get; set; }

        public Ballot Ballot { get; set; }

        public List<Vote> Votes { get; set; }
    }
}