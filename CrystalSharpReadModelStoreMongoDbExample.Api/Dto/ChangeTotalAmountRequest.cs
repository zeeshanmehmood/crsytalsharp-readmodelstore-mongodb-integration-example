using System;

namespace CrystalSharpReadModelStoreMongoDbExample.Api.Dto
{
    public class ChangeTotalAmountRequest
    {
        public Guid OrderGlobalUId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
