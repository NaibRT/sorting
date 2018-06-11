using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_part05.Model
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        /*
        public Product()
        {

        }

        public Product(int _id,string _name, int _price)
        {
            Name = _name;
            Price = _price;
            Id = _id;
        }

        public Product(string _name,int _price)
        {
            
            Name = _name;
            Price = _price;
            Id = Entity.id.Next(5000);
            Entity.Products.Add(this);

        }
        */
        
    }
}
