using System.ComponentModel.DataAnnotations;

namespace Megus.Common.Entities
{
    /// <summary>
    /// Define to base entities
    /// </summary>
    public class BaseEntities
    {
        [Key]
        public int Id { get; set; }
    }
}
