using System;
using CrystalSharp.Application;
using CrystalSharpReadModelStoreMongoDbExample.Application.Responses;

namespace CrystalSharpReadModelStoreMongoDbExample.Application.Commands
{
    public class DeleteOrderCommand : ICommand<CommandExecutionResult<DeleteOrderResponse>>
    {
        public Guid GlobalUId { get; set; }
    }
}
