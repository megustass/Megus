using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Megus.Common.Entities;

namespace Megus.API.Repositories.Entities
{
    public class ProductSizeEntity : BaseEntities
    {
        public int ProductId { get; set; }
        public int SizeId { get; set; }

        [ForeignKey("ProductId")]
        public virtual ProductEntity ProductEntity { get; set; }
        [ForeignKey("SizeId")]
        public virtual SizeEntity SizeEntity { get; set; }
    }
}
