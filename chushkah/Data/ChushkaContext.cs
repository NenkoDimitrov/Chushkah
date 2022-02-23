using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chushkah.Data
{
    public class ChushkaContext : DbContext
    {
        public ChushkaContext(DbContextOptions<ChushkaContext>op): base(op)
        {

        }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
    }
}
