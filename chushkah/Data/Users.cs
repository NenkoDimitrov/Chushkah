using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chushkah.Data
{
    
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public RoleType Role { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
