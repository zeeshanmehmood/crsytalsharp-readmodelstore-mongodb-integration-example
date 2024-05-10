using System;

namespace CrystalSharpReadModelStoreMongoDbExample.Application.Responses
{
    public class OrderResponse
    {
        public Guid GlobalUId { get; set; }
        public string OrderCode { get; set; }
    }
}
