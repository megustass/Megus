using System.ComponentModel.DataAnnotations.Schema;
using Megus.Common.Entities;

namespace Megus.API.Repositories.Entities
{
    public class ImageEntity : BaseEntities
    {
        public string Link { get; set; }
        public string ImageSource { get; set; }
        public int ImageTypeId { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("ImageTypeId")]
        public virtual ImageTypeEntity ImageTypeEntity { get; set; }
        [ForeignKey("ProductId")]
        public virtual ProductEntity ProductEntity { get; set; }
    }
}
