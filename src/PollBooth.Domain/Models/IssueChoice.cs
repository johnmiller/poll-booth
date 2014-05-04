using System.ComponentModel.DataAnnotations;

namespace PollBooth.Domain.Models
{
    public class IssueChoice
    {
        public int Id { get; set; }

        [Required]
        public int IssueId { get; set; }

        [Required]
        public string Text { get; set; }
    }
}