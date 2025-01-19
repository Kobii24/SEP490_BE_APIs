using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS;

/*Sign the completed request with the Unit data type*/
/*TCommand, TResponse is a flexible data type defining by coder*/
public interface ICommand : IRequest<Unit>
{

}
/*Sign the completed request with the flexible TRequest data type*/
/*TCommand, TResponse is a flexible data type defining by coder*/
public interface ICommand<out TResponse> : IRequest<TResponse>
{

}
