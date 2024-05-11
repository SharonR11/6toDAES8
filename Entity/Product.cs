using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        public int product_id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int stock { get; set; }
        public int active { get; set; }

    }
}
