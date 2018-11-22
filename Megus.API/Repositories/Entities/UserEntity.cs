using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Megus.Common.Entities;

namespace Megus.API.Repositories.Entities
{
    public class UserEntity : BaseEntities
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PassWord { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public virtual RoleEntity RoleEntity { get; set; }
    }
}
