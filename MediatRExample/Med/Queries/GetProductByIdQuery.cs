using System;

using MediatR;

namespace MediatRExample.Med.Queries
{
	public class GetProductByIdQuery:IRequest<GetProductViewModel>
	{
		public Guid	 Id { get; set; }
	}
}
