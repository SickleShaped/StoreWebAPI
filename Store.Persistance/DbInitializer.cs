using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Persistance
{
    public class DbInitializer
    {
        public static void Initialize(ProductDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
