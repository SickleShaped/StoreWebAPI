using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    public class Cart
    {
        public Guid UserId { get; set; }
        public Product[] Product { get; set; }
        public float TotalCost { get; set; }

    
    }
}
