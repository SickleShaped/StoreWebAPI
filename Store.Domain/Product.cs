using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    public  class Product
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public float ProductCost { get;set; }

    }
}
