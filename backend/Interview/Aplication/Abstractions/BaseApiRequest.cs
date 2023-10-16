using MediatR;

namespace Aplication.Abstractions
{
    public record BaseApiRequest<TResponseType> : IRequest<ApiResponse<TResponseType>>;
}
