using Megus.Common.Attributes;

namespace Megus.Common.Enums
{
    public enum ProductStatus
    {
        [ReferenceEnum("Còn Hàng", Code = "0")]
        HasProducts = 0,
        [ReferenceEnum("Sắp Có Hàng", Code = "1")]
        CommingOutProducts = 1,
        [ReferenceEnum("Hết Hàng", Code = "2")]
        OutOfProducts = 2,
        [ReferenceEnum("Ngừng Bán", Code = "3")]
        StopSale = 3
    }
}
