using Aplication.Interfaces;
using MediatR;

namespace Aplication.Abstractions.Handlers
{
    public abstract class BaseHandler<TX, TY> : IRequestHandler<TX, TY>
        where TX : IRequest<TY>
    {
        protected readonly IAppDbContext DataContext;

        protected BaseHandler(IAppDbContext dataContext)
        {
            DataContext = dataContext;
        }

        public abstract Task<TY> Handle(TX request, CancellationToken cancellationToken);
    }
}
