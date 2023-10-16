using Aplication.Interfaces;
using MediatR;

namespace Aplication.Abstractions.Handlers
{
    public abstract class BaseApiHandler<TRequestType, TResponseType> : BaseHandler<TRequestType, ApiResponse<TResponseType>> where TRequestType : IRequest<ApiResponse<TResponseType>>
    {
        protected BaseApiHandler(IAppDbContext dataContext) : base(dataContext)
        {
        }

        protected ApiResponse<TResponseType> Response(TResponseType payload)
        {
            return new ApiResponse<TResponseType>(payload);
        }
    }
}
