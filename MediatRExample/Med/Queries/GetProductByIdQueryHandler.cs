using System;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

namespace MediatRExample.Med.Queries
{
	public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
	{
		public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
		{
			var viewModel = new GetProductViewModel()
			{
				Id = Guid.NewGuid(),
				Name = "Book"
			};
			return Task.FromResult(viewModel);

			//Get Product from Respository
		}
	}
}
