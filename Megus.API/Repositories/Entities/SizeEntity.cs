using System.Collections.Generic;
using Megus.Common.Entities;

namespace Megus.API.Repositories.Entities
{
    public class SizeEntity : BaseEntities
    {
        public string Name { get; set; }
        
        public virtual ICollection<ProductSizeEntity> ProductSizeEntities { get; set; }
    }
}
