using System;
using CrystalSharp.Application;
using CrystalSharp.Infrastructure.Paging;
using CrystalSharpReadModelStoreMongoDbExample.Application.ReadModels;

namespace CrystalSharpReadModelStoreMongoDbExample.Application.Queries
{
    public class CustomerOrderListQuery : IQuery<QueryExecutionResult<PagedResult<CustomerOrderReadModel>>>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public Guid CustomerGlobalUId { get; set; }
    }
}
