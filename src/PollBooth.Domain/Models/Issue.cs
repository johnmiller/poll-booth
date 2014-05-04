using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PollBooth.Domain.Models
{
    public class Issue
    {
        public int Id { get; set; }

        [Required]
        public int BallotId { get; set; }

        [Required]
        public int Order { get; set; }

        [Required]
        public string Text { get; set; }

        public List<IssueChoice> IssueChoices { get; set; } 
    }
}