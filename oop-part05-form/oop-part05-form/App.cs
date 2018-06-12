using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using oop_part05_form.Model;

namespace oop_part05_form
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            foreach (var item in Entity.Categories)
            {
                categoryList.Items.Add(item.Name);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var name = productName.Text;
            var price = Convert.ToInt32(productPrice.Text);
            var category = categoryList.SelectedItem.ToString();
            ProductController.Create(name, price, category);



        }

        private void showButton_Click(object sender, EventArgs e)
        {
            productListView.Text = string.Empty;
            foreach (var item in Entity.Products)
            {
                productListView.Text += item.Id + " . " + item.Name + " / "+ item.CategoryName + " / " +item.Price + "\r\n";
            }
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            var name = categoryName.Text;
            var cat = new Category();
            cat.Name = name;
            Entity.Categories.Add(cat);
            categoryList.Items.Clear();
            foreach (var item in Entity.Categories)
            {
                categoryList.Items.Add(item.Name);
            }
        }

        private void catProductsButton_Click(object sender, EventArgs e)
        {
            var selectedCategory = categoryList.SelectedItem.ToString();
            productListView.Text = string.Empty;
            foreach (var item in Entity.Products)
            {
                if (item.CategoryName == selectedCategory)
                {
                    productListView.Text += item.Id + " . " + item.Name + " / " + item.CategoryName + " / " + item.Price + "\r\n";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productListView.Text = string.Empty;
            Product[] arr = new Product[Entity.Products.Count];
            int j = 0;
            foreach (var item in Entity.Products)
            {
                arr[j++] = item;
            }
            Product temp;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int c = 0; c < arr.Length-1; c++)
                {
                    int x = String.Compare(arr[c].Name, arr[c + 1].Name);
                    if (x == 1)
                    {
                       
                        temp = arr[c + 1];
                        arr[c + 1] = arr[c];
                        arr[c] = temp;
                      
                    }
                }
               

            }
            foreach (var item in arr)
            {
                productListView.Text += item.Id + " . " + item.Name + " / " + item.CategoryName + " / " + item.Price + "\r\n";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            productListView.Text = string.Empty;
            Product[] arr = new Product[Entity.Products.Count];
            int i = 0;
            foreach (var item in Entity.Products)
            {
                arr[i++] = item;
            }
            Product temp;
            for (int j = 0; j < arr.Length-1; j++)
            {
                for (int a = 0; a < arr.Length-1; a++)
                {
                    if (arr[a].Price>arr[a+1].Price)
                    {
                        temp = arr[a + 1];
                        arr[a + 1]= arr[a];
                        arr[a] = temp;

                    }

                }
            }

            foreach (var item in arr)
            {
                productListView.Text += item.Id + " . " + item.Name + " / " + item.CategoryName + " / " + item.Price + "\r\n";
            }
            
        }

        private void App_Load(object sender, EventArgs e)
        {

        }
    }
}
