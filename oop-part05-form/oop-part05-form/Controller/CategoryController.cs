using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_part05_form.Model;

namespace oop_part05_form.Controller
{
    class CategoryController
    {
        public static void Create(string _name)
        {

            var cat = new Category();
            cat.Name = _name;
           
            Entity.Categories.Add(cat);
        }

        public static List<Category> Read()
        {
            return Entity.Categories;
        }
    }
}
