using System;
using CrystalSharp.Application;
using CrystalSharpReadModelStoreMongoDbExample.Application.ReadModels;

namespace CrystalSharpReadModelStoreMongoDbExample.Application.Queries
{
    public class CustomerOrderDetailQuery : IQuery<QueryExecutionResult<CustomerOrderReadModel>>
    {
        public Guid OrderGlobaUId { get; set; }
    }
}
