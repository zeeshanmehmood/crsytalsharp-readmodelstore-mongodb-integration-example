using System.Threading;
using System.Threading.Tasks;
using CrystalSharp.Application;
using CrystalSharp.Application.Handlers;
using CrystalSharp.Infrastructure.ReadModelStoresPersistence;
using CrystalSharpReadModelStoreMongoDbExample.Application.Queries;
using CrystalSharpReadModelStoreMongoDbExample.Application.ReadModels;

namespace CrystalSharpReadModelStoreMongoDbExample.Application.QueryHandlers
{
    public class CustomerOrderDetailQueryHandler : QueryHandler<CustomerOrderDetailQuery, CustomerOrderReadModel>
    {
        private readonly IReadModelStore<string> _readModelStore;

        public CustomerOrderDetailQueryHandler(IReadModelStore<string> readModelStore)
        {
            _readModelStore = readModelStore;
        }

        public override async Task<QueryExecutionResult<CustomerOrderReadModel>> Handle(CustomerOrderDetailQuery request, CancellationToken cancellationToken = default)
        {
            if (request == null) return await Fail("Invalid query.");

            CustomerOrderReadModel readModel = await _readModelStore.Find<CustomerOrderReadModel>(request.OrderGlobaUId, cancellationToken).ConfigureAwait(false);

            if (readModel == null)
            {
                return await Fail("Customer order not found.");
            }

            return await Ok(readModel);
        }
    }
}
