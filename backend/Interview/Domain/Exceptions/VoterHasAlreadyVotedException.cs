namespace Domain.Exceptions
{
    public class VoterHasAlreadyVotedException : BadRequestException
    {        
        public VoterHasAlreadyVotedException(int voterId) : base($"VoterId - {voterId} has already voted") { }
    }
}
