namespace oop_part05_form
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productName = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.productListView = new System.Windows.Forms.RichTextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.categoryList = new System.Windows.Forms.ComboBox();
            this.categoryName = new System.Windows.Forms.TextBox();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.catProductsButton = new System.Windows.Forms.Button();
            this.showforprice = new System.Windows.Forms.Button();
            this.showforname = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(12, 12);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(177, 20);
            this.productName.TabIndex = 0;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(12, 38);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(177, 20);
            this.productPrice.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(114, 95);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Product";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productListView
            // 
            this.productListView.Location = new System.Drawing.Point(383, 12);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(405, 407);
            this.productListView.TabIndex = 2;
            this.productListView.Text = "";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(255, 12);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "SHOW";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // categoryList
            // 
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Location = new System.Drawing.Point(13, 65);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(176, 21);
            this.categoryList.TabIndex = 4;
            // 
            // categoryName
            // 
            this.categoryName.Location = new System.Drawing.Point(13, 134);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(176, 20);
            this.categoryName.TabIndex = 5;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(69, 161);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(120, 23);
            this.addCategoryButton.TabIndex = 6;
            this.addCategoryButton.Text = "Add Category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // catProductsButton
            // 
            this.catProductsButton.Location = new System.Drawing.Point(222, 65);
            this.catProductsButton.Name = "catProductsButton";
            this.catProductsButton.Size = new System.Drawing.Size(139, 23);
            this.catProductsButton.TabIndex = 7;
            this.catProductsButton.Text = "Show Category Products";
            this.catProductsButton.UseVisualStyleBackColor = true;
            this.catProductsButton.Click += new System.EventHandler(this.catProductsButton_Click);
            // 
            // showforprice
            // 
            this.showforprice.Location = new System.Drawing.Point(222, 94);
            this.showforprice.Name = "showforprice";
            this.showforprice.Size = new System.Drawing.Size(139, 23);
            this.showforprice.TabIndex = 8;
            this.showforprice.Text = "Show for price";
            this.showforprice.UseVisualStyleBackColor = true;
            this.showforprice.Click += new System.EventHandler(this.button1_Click);
            // 
            // showforname
            // 
            this.showforname.Location = new System.Drawing.Point(222, 123);
            this.showforname.Name = "showforname";
            this.showforname.Size = new System.Drawing.Size(139, 23);
            this.showforname.TabIndex = 9;
            this.showforname.Text = "Show for Name";
            this.showforname.UseVisualStyleBackColor = true;
            this.showforname.Click += new System.EventHandler(this.button2_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.showforname);
            this.Controls.Add(this.showforprice);
            this.Controls.Add(this.catProductsButton);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.categoryList);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.productListView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productName);
            this.Name = "App";
            this.Text = "ADD";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox productListView;
        private System.Windows.Forms.Button showButton;
        public System.Windows.Forms.ComboBox categoryList;
        private System.Windows.Forms.TextBox categoryName;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Button catProductsButton;
        private System.Windows.Forms.Button showforprice;
        private System.Windows.Forms.Button showforname;
    }
}