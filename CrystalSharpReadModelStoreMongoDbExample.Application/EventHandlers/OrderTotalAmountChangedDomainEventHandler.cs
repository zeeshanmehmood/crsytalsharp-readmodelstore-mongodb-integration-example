using System.Threading;
using System.Threading.Tasks;
using CrystalSharp.Domain.Infrastructure;
using CrystalSharp.Infrastructure.ReadModelStoresPersistence;
using CrystalSharpReadModelStoreMongoDbExample.Application.Domain.Aggregates.OrderAggregate.Events;
using CrystalSharpReadModelStoreMongoDbExample.Application.ReadModels;

namespace CrystalSharpReadModelStoreMongoDbExample.Application.EventHandlers
{
    public class OrderTotalAmountChangedDomainEventHandler : ISynchronousDomainEventHandler<OrderTotalAmountChangedDomainEvent>
    {
        private readonly IReadModelStore<string> _readModelStore;

        public OrderTotalAmountChangedDomainEventHandler(IReadModelStore<string> readModelStore)
        {
            _readModelStore = readModelStore;
        }

        public async Task Handle(OrderTotalAmountChangedDomainEvent notification, CancellationToken cancellationToken = default)
        {
            CustomerOrderReadModel readModel = await _readModelStore.Find<CustomerOrderReadModel>(notification.StreamId, cancellationToken).ConfigureAwait(false);

            if (readModel != null)
            {
                readModel.TotalAmount = notification.TotalAmount;

                await _readModelStore.Update(readModel, cancellationToken).ConfigureAwait(false);
            }
        }
    }
}
