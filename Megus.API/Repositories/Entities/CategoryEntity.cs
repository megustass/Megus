using System.Collections.Generic;
using Megus.Common.Entities;

namespace Megus.API.Repositories.Entities
{
    public class CategoryEntity : BaseEntities
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int IsHasChild { get; set; }

        public virtual ICollection<ProductEntity> ProductEntities { get; set; }
    }
}
