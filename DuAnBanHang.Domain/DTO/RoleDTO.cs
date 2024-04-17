using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnBanHang.Domain.DTO
{
    public class RoleDTO
    {
        public Guid ID { get; set; }
        public string RoleName { get; set; } = string.Empty;
    }
}
