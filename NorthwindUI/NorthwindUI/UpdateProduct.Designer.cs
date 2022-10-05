namespace NorthwindUI
{
    partial class UpdateProduct
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
            this.discontinued = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.ProductUpdate = new System.Windows.Forms.Button();
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
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // discontinued
            // 
            this.discontinued.AutoSize = true;
            this.discontinued.Location = new System.Drawing.Point(170, 388);
            this.discontinued.Name = "discontinued";
            this.discontinued.Size = new System.Drawing.Size(96, 19);
            this.discontinued.TabIndex = 147;
            this.discontinued.Text = "Discontinued";
            this.discontinued.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 146;
            this.label1.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(172, 337);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(223, 23);
            this.name.TabIndex = 145;
            // 
            // ProductUpdate
            // 
            this.ProductUpdate.Location = new System.Drawing.Point(299, 388);
            this.ProductUpdate.Name = "ProductUpdate";
            this.ProductUpdate.Size = new System.Drawing.Size(75, 23);
            this.ProductUpdate.TabIndex = 144;
            this.ProductUpdate.Text = "Ekle";
            this.ProductUpdate.UseVisualStyleBackColor = true;
            this.ProductUpdate.Click += new System.EventHandler(this.ProductUpdate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 143;
            this.label11.Text = "ReorderLevel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 142;
            this.label5.Text = "UnitsOnOrder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 141;
            this.label6.Text = "UnitsInStock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 140;
            this.label7.Text = "UnitPrice";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 139;
            this.label8.Text = "QuantityPerUnit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 138;
            this.label3.Text = "CategoryId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 137;
            this.label2.Text = "SupplierId";
            // 
            // reorderLevel
            // 
            this.reorderLevel.Location = new System.Drawing.Point(172, 299);
            this.reorderLevel.Name = "reorderLevel";
            this.reorderLevel.Size = new System.Drawing.Size(223, 23);
            this.reorderLevel.TabIndex = 136;
            // 
            // unitsOnOrder
            // 
            this.unitsOnOrder.Location = new System.Drawing.Point(172, 260);
            this.unitsOnOrder.Name = "unitsOnOrder";
            this.unitsOnOrder.Size = new System.Drawing.Size(223, 23);
            this.unitsOnOrder.TabIndex = 135;
            // 
            // unitsInStock
            // 
            this.unitsInStock.Location = new System.Drawing.Point(172, 222);
            this.unitsInStock.Name = "unitsInStock";
            this.unitsInStock.Size = new System.Drawing.Size(223, 23);
            this.unitsInStock.TabIndex = 134;
            // 
            // unitPrice
            // 
            this.unitPrice.Location = new System.Drawing.Point(172, 183);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(223, 23);
            this.unitPrice.TabIndex = 133;
            // 
            // quantityPerUnit
            // 
            this.quantityPerUnit.Location = new System.Drawing.Point(172, 145);
            this.quantityPerUnit.Name = "quantityPerUnit";
            this.quantityPerUnit.Size = new System.Drawing.Size(223, 23);
            this.quantityPerUnit.TabIndex = 132;
            // 
            // categoryId
            // 
            this.categoryId.Location = new System.Drawing.Point(172, 102);
            this.categoryId.Name = "categoryId";
            this.categoryId.Size = new System.Drawing.Size(223, 23);
            this.categoryId.TabIndex = 131;
            // 
            // supplierId
            // 
            this.supplierId.Location = new System.Drawing.Point(172, 64);
            this.supplierId.Name = "supplierId";
            this.supplierId.Size = new System.Drawing.Size(223, 23);
            this.supplierId.TabIndex = 130;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 149;
            this.label4.Text = "SupplierId";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(258, 31);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(17, 15);
            this.id.TabIndex = 150;
            this.id.Text = "id";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 427);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.discontinued);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.ProductUpdate);
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
            this.Name = "UpdateProduct";
            this.Text = "UpdateProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button ProductUpdate;
        private Label label11;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label2;
        private Label label4;
        internal CheckBox discontinued;
        internal TextBox name;
        internal TextBox reorderLevel;
        internal TextBox unitsOnOrder;
        internal TextBox unitsInStock;
        internal TextBox unitPrice;
        internal TextBox quantityPerUnit;
        internal TextBox categoryId;
        internal TextBox supplierId;
        internal Label id;
    }
}