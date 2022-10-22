using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public Product[] Product { get; set; }
        public float TotalCost { get; set; }
        public Guid UserId { get; set; }
    }
}
