namespace Aplication.Features.Voters.Models
{
    public class VoterDto
    {
        public VoterDto(int id, string name) : this(id, name, false)
        {
        }
        public VoterDto(int id, string name, bool hasVoted)
        {
            Id = id;
            Name = name;
            HasVoted = hasVoted;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasVoted { get; set; }
    }
}
