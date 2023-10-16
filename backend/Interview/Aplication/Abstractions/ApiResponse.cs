namespace Aplication.Abstractions
{
    public record ApiResponse<TPayloadType>(TPayloadType Payload);
}
