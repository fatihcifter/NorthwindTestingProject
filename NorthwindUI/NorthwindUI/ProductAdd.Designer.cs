namespace NorthwindUI
{
    partial class ProductAdd
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
            this.PostProduct = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reorderLevel = new System.Windows.Forms.TextBox();
            this.unitsOnOrder = new System.Windows.Forms.TextBox();
            this.unitsInStock = new System.Windows.Forms.TextBox();
            this.unitPrice = new System.Windows.Forms.TextBox();
            this.quantityPerUnit = new System.Windows.Forms.TextBox();
            this.categoryId = new System.Windows.Forms.TextBox();
            this.supplierId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.discontinued = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PostProduct
            // 
            this.PostProduct.Location = new System.Drawing.Point(270, 387);
            this.PostProduct.Name = "PostProduct";
            this.PostProduct.Size = new System.Drawing.Size(75, 23);
            this.PostProduct.TabIndex = 124;
            this.PostProduct.Text = "Ekle";
            this.PostProduct.UseVisualStyleBackColor = true;
            this.PostProduct.Click += new System.EventHandler(this.PostProduct_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 112;
            this.label11.Text = "ReorderLevel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 111;
            this.label5.Text = "UnitsOnOrder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 110;
            this.label6.Text = "UnitsInStock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 109;
            this.label7.Text = "UnitPrice";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 108;
            this.label8.Text = "QuantityPerUnit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 107;
            this.label3.Text = "CategoryId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 106;
            this.label2.Text = "SupplierId";
            // 
            // reorderLevel
            // 
            this.reorderLevel.Location = new System.Drawing.Point(143, 298);
            this.reorderLevel.Name = "reorderLevel";
            this.reorderLevel.Size = new System.Drawing.Size(223, 23);
            this.reorderLevel.TabIndex = 95;
            // 
            // unitsOnOrder
            // 
            this.unitsOnOrder.Location = new System.Drawing.Point(143, 259);
            this.unitsOnOrder.Name = "unitsOnOrder";
            this.unitsOnOrder.Size = new System.Drawing.Size(223, 23);
            this.unitsOnOrder.TabIndex = 94;
            // 
            // unitsInStock
            // 
            this.unitsInStock.Location = new System.Drawing.Point(143, 221);
            this.unitsInStock.Name = "unitsInStock";
            this.unitsInStock.Size = new System.Drawing.Size(223, 23);
            this.unitsInStock.TabIndex = 93;
            // 
            // unitPrice
            // 
            this.unitPrice.Location = new System.Drawing.Point(143, 182);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(223, 23);
            this.unitPrice.TabIndex = 92;
            this.unitPrice.TextChanged += new System.EventHandler(this.shippedDate_TextChanged);
            // 
            // quantityPerUnit
            // 
            this.quantityPerUnit.Location = new System.Drawing.Point(143, 144);
            this.quantityPerUnit.Name = "quantityPerUnit";
            this.quantityPerUnit.Size = new System.Drawing.Size(223, 23);
            this.quantityPerUnit.TabIndex = 91;
            // 
            // categoryId
            // 
            this.categoryId.Location = new System.Drawing.Point(143, 101);
            this.categoryId.Name = "categoryId";
            this.categoryId.Size = new System.Drawing.Size(223, 23);
            this.categoryId.TabIndex = 90;
            // 
            // supplierId
            // 
            this.supplierId.Location = new System.Drawing.Point(143, 63);
            this.supplierId.Name = "supplierId";
            this.supplierId.Size = new System.Drawing.Size(223, 23);
            this.supplierId.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 128;
            this.label1.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(143, 336);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(223, 23);
            this.name.TabIndex = 126;
            // 
            // discontinued
            // 
            this.discontinued.AutoSize = true;
            this.discontinued.Location = new System.Drawing.Point(141, 387);
            this.discontinued.Name = "discontinued";
            this.discontinued.Size = new System.Drawing.Size(96, 19);
            this.discontinued.TabIndex = 129;
            this.discontinued.Text = "Discontinued";
            this.discontinued.UseVisualStyleBackColor = true;
            // 
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 514);
            this.Controls.Add(this.discontinued);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.PostProduct);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reorderLevel);
            this.Controls.Add(this.unitsOnOrder);
            this.Controls.Add(this.unitsInStock);
            this.Controls.Add(this.unitPrice);
            this.Controls.Add(this.quantityPerUnit);
            this.Controls.Add(this.categoryId);
            this.Controls.Add(this.supplierId);
            this.Name = "ProductAdd";
            this.Text = "ProductAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PostProduct;
        private Label label11;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label2;
        private TextBox reorderLevel;
        private TextBox unitsOnOrder;
        private TextBox unitsInStock;
        private TextBox unitPrice;
        private TextBox quantityPerUnit;
        private TextBox categoryId;
        private TextBox supplierId;
        private Label label1;
        private TextBox name;
        private CheckBox discontinued;
    }
}