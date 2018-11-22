using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Megus.Common.Entities;

namespace Megus.API.Repositories.Entities
{
    public class ProductEntity : BaseEntities
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public int SaleOff { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Description { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public int StatusId { get; set; }
        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual CategoryEntity CategoryEntity { get; set; }
        [ForeignKey("StatusId")]
        public virtual ProductStatusEntity ProductStatusEntity { get; set; }
        public virtual ICollection<ImageEntity> ImageEntities { get; set; }
        public virtual ICollection<ProductSizeEntity> ProductSizeEntities { get; set; }
    }
}
