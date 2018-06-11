using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_part05_form.Model;

namespace oop_part05_form
{
    class ProductController
    {
        public static void Create(string _name,int _price,string _catName)
        {

            var product = new Product();
            product.Name = _name;
            product.Price = _price;
            product.Id = ++Entity.id;
            product.CategoryName = _catName;
            Entity.Products.Add(product);
        }

        public static List<Product> Read()
        {
            return Entity.Products;
        }
    }
}
