using System.Collections.Generic;
using Megus.Common.Entities;

namespace Megus.API.Repositories.Entities
{
    public class ProductStatusEntity : BaseEntities
    {
        public string Name { get; set; }

        public virtual ICollection<ProductEntity> ProductEntities { get; set; }
    }
}
