using System.Collections.Generic;

namespace PollBooth.Domain.Models
{
    public class Ballot
    {
        public int Id { get; set; }
        public List<Issue> Issues { get; set; }
    }
}
