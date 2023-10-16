namespace Domain.Entites
{
    public class Candidate : Entity
    {
        public Candidate()
        {
        }

        public Candidate(string name) : base()
        {
            Name = name;
        }

        public string? Name { get; set; }
        public IList<Voter>? Voters { get; set; }
    }
}
