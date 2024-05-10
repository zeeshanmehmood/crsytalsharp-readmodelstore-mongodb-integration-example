using System;
using CrystalSharp.Application;
using CrystalSharpReadModelStoreMongoDbExample.Application.Responses;

namespace CrystalSharpReadModelStoreMongoDbExample.Application.Commands
{
    public class ChangeTotalAmountCommand : ICommand<CommandExecutionResult<OrderResponse>>
    {
        public Guid GlobalUId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
