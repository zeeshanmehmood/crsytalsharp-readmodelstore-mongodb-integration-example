using System;
using CrystalSharp.Application;
using CrystalSharpReadModelStoreMongoDbExample.Application.Responses;

namespace CrystalSharpReadModelStoreMongoDbExample.Application.Commands
{
    public class PlaceOrderCommand : ICommand<CommandExecutionResult<OrderResponse>>
    {
        public Guid CustomerId { get; set; }
        public string Item { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
