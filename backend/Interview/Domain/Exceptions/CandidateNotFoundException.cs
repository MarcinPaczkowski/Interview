namespace Domain.Exceptions
{
    public class CandidateNotFoundException : NotFoundException
    {
        public CandidateNotFoundException(int candidateId) : base($"CandidateId - {candidateId} was not found!") { }
    }
}
