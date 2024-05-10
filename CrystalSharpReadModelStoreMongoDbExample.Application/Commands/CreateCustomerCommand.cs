using CrystalSharp.Application;
using CrystalSharpReadModelStoreMongoDbExample.Application.Responses;

namespace CrystalSharpReadModelStoreMongoDbExample.Application.Commands
{
    public class CreateCustomerCommand : ICommand<CommandExecutionResult<CustomerResponse>>
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
