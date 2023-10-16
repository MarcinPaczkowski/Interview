namespace Aplication.Features.Candidates.Models
{
    public class CandidateDto
    {
        public CandidateDto(int id, string name) : this(id, name, 0)
        {
        }
        public CandidateDto(int id, string name, int castedVotes)
        {
            Id = id;
            Name = name;
            CastedVotes = castedVotes;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int CastedVotes { get; set; }
    }
}
