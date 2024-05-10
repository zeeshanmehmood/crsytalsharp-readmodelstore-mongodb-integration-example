using System;
using CrystalSharp.Infrastructure.ReadModels;

namespace CrystalSharpReadModelStoreMongoDbExample.Application.ReadModels
{
    public class CustomerOrderReadModel : ReadModel<string>
    {
        public string OrderCode { get; set; }
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string Item { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
