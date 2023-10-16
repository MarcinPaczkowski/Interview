namespace Domain.Exceptions
{
    public class VoterNotFoundException : NotFoundException
    {
        public VoterNotFoundException(int voterId) : base($"VoterId - {voterId} was not found!") { }
    }
}
