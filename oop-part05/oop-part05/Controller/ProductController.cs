using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_part05.Model;

namespace oop_part05.Controller
{
    class ProductController
    {
        public void Create(){
            var product=new Product();
            _product.Id=Entity.id.Next(1000);
            Entity.Products.Add(_product);
        }
    }
}
