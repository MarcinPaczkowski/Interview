namespace Domain.Entites
{
    public class Voter : Entity
    {
        public Voter()
        {
            
        }

        public Voter(string name) : base()
        {
            Name = name;
        }

        public string? Name { get; set; }
        public int? CandidateId { get; set; }
        public Candidate? Candidate { get; set; }

        public void Vote(int candidateId)
        {
            CandidateId = candidateId;
        }

        public bool HasVoted()
        {
            return Candidate != null;
        }
    }
}
