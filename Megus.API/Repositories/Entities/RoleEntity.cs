using System.Collections.Generic;
using Megus.Common.Entities;

namespace Megus.API.Repositories.Entities
{
    public class RoleEntity : BaseEntities
    {
        public string Name { get; set; }

        public virtual ICollection<UserEntity> Users { get; set; }
    }
}
