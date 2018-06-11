using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_part05.Model
{
    class Entity
    {
        public static Random id = new Random();
        public static List<Product> Products = new List<Product>() {
            new Product(1,"Portagal",8),
            new Product("Telefon",500)
        };
    }
}
