using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chushkah.Data
{
    public class Orders
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int UserId { get; set; }
        public virtual Users Users { get; set; }
        public DateTime OrderedOn { get; set; }
    }
}
