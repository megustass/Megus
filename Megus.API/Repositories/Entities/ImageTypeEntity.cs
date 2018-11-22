using System.Collections.Generic;
using Megus.Common.Entities;

namespace Megus.API.Repositories.Entities
{
    public class ImageTypeEntity : BaseEntities
    {
        public string Name { get; set; }
        
        public virtual ICollection<ImageEntity> ImageEntities { get; set; }
    }
}
