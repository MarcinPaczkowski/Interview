namespace Aplication.Features.Voters.Models
{
    public class VoteRequest
    {
        public int VoterId { get; set; }
        public int CandidateId { get; set; }
    }
}
