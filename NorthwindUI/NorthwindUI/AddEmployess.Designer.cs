namespace NorthwindUI
{
    partial class AddEmployess
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
            this.label17 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.territoryId = new System.Windows.Forms.TextBox();
            this.territoryAdd = new System.Windows.Forms.Button();
            this.territoryView = new System.Windows.Forms.ListView();
            this.territoryIds = new System.Windows.Forms.ColumnHeader();
            this.PostEmployess = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.postalCode = new System.Windows.Forms.TextBox();
            this.region = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.reportsTo = new System.Windows.Forms.TextBox();
            this.notes = new System.Windows.Forms.TextBox();
            this.hireDate = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.TextBox();
            this.titleOfCourtesy = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(509, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 15);
            this.label17.TabIndex = 185;
            this.label17.Text = "Phone";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(559, 264);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(223, 23);
            this.phone.TabIndex = 184;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(490, 349);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 15);
            this.label16.TabIndex = 182;
            this.label16.Text = "Territory Id";
            // 
            // territoryId
            // 
            this.territoryId.Location = new System.Drawing.Point(559, 341);
            this.territoryId.Name = "territoryId";
            this.territoryId.Size = new System.Drawing.Size(134, 23);
            this.territoryId.TabIndex = 181;
            // 
            // territoryAdd
            // 
            this.territoryAdd.Location = new System.Drawing.Point(572, 380);
            this.territoryAdd.Name = "territoryAdd";
            this.territoryAdd.Size = new System.Drawing.Size(95, 35);
            this.territoryAdd.TabIndex = 180;
            this.territoryAdd.Text = "Territory Add";
            this.territoryAdd.UseVisualStyleBackColor = true;
            this.territoryAdd.Click += new System.EventHandler(this.territoryAdd_Click);
            // 
            // territoryView
            // 
            this.territoryView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.territoryIds});
            this.territoryView.Location = new System.Drawing.Point(702, 341);
            this.territoryView.Name = "territoryView";
            this.territoryView.Size = new System.Drawing.Size(117, 149);
            this.territoryView.TabIndex = 179;
            this.territoryView.UseCompatibleStateImageBehavior = false;
            this.territoryView.View = System.Windows.Forms.View.Details;
            // 
            // territoryIds
            // 
            this.territoryIds.Text = "TerritoryIds";
            this.territoryIds.Width = 90;
            // 
            // PostEmployess
            // 
            this.PostEmployess.Location = new System.Drawing.Point(392, 439);
            this.PostEmployess.Name = "PostEmployess";
            this.PostEmployess.Size = new System.Drawing.Size(158, 66);
            this.PostEmployess.TabIndex = 178;
            this.PostEmployess.Text = "Add Employee";
            this.PostEmployess.UseVisualStyleBackColor = true;
            this.PostEmployess.Click += new System.EventHandler(this.PostEmployess_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(503, 226);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 15);
            this.label20.TabIndex = 177;
            this.label20.Text = "Country";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(486, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 176;
            this.label13.Text = "PostalCode";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(509, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 175;
            this.label14.Text = "Region";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(525, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 15);
            this.label15.TabIndex = 174;
            this.label15.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(516, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 173;
            this.label12.Text = "Street";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(632, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 172;
            this.label10.Text = "TerritoryIds";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 171;
            this.label9.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(114, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 15);
            this.label11.TabIndex = 170;
            this.label11.Text = "ReportsTo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 169;
            this.label5.Text = "Notes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 168;
            this.label6.Text = "HireDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 167;
            this.label7.Text = "BirthDate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 166;
            this.label8.Text = "TitleOfCourtesy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 165;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 164;
            this.label4.Text = "LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 163;
            this.label2.Text = "FirstName";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(559, 221);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(223, 23);
            this.country.TabIndex = 162;
            // 
            // postalCode
            // 
            this.postalCode.Location = new System.Drawing.Point(559, 178);
            this.postalCode.Name = "postalCode";
            this.postalCode.Size = new System.Drawing.Size(223, 23);
            this.postalCode.TabIndex = 161;
            // 
            // region
            // 
            this.region.Location = new System.Drawing.Point(559, 140);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(223, 23);
            this.region.TabIndex = 160;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(559, 101);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(223, 23);
            this.city.TabIndex = 159;
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(559, 63);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(223, 23);
            this.street.TabIndex = 158;
            // 
            // reportsTo
            // 
            this.reportsTo.Location = new System.Drawing.Point(181, 340);
            this.reportsTo.Name = "reportsTo";
            this.reportsTo.Size = new System.Drawing.Size(223, 23);
            this.reportsTo.TabIndex = 157;
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(181, 301);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(223, 23);
            this.notes.TabIndex = 156;
            // 
            // hireDate
            // 
            this.hireDate.Location = new System.Drawing.Point(181, 263);
            this.hireDate.Name = "hireDate";
            this.hireDate.Size = new System.Drawing.Size(223, 23);
            this.hireDate.TabIndex = 155;
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(181, 224);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(223, 23);
            this.birthDate.TabIndex = 154;
            // 
            // titleOfCourtesy
            // 
            this.titleOfCourtesy.Location = new System.Drawing.Point(181, 186);
            this.titleOfCourtesy.Name = "titleOfCourtesy";
            this.titleOfCourtesy.Size = new System.Drawing.Size(223, 23);
            this.titleOfCourtesy.TabIndex = 153;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(181, 143);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(223, 23);
            this.title.TabIndex = 152;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(181, 105);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(223, 23);
            this.lastName.TabIndex = 151;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(181, 66);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(223, 23);
            this.firstName.TabIndex = 150;
            // 
            // AddEmployess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 561);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.territoryId);
            this.Controls.Add(this.territoryAdd);
            this.Controls.Add(this.territoryView);
            this.Controls.Add(this.PostEmployess);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.country);
            this.Controls.Add(this.postalCode);
            this.Controls.Add(this.region);
            this.Controls.Add(this.city);
            this.Controls.Add(this.street);
            this.Controls.Add(this.reportsTo);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.hireDate);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.titleOfCourtesy);
            this.Controls.Add(this.title);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "AddEmployess";
            this.Text = "AddEmployess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label label17;
        internal TextBox phone;
        internal Label label16;
        internal TextBox territoryId;
        internal Button territoryAdd;
        internal ListView territoryView;
        private ColumnHeader territoryIds;
        internal Button PostEmployess;
        internal Label label20;
        internal Label label13;
        internal Label label14;
        internal Label label15;
        internal Label label12;
        internal Label label10;
        private Label label9;
        private Label label11;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label label2;
        internal TextBox country;
        internal TextBox postalCode;
        internal TextBox region;
        internal TextBox city;
        internal TextBox street;
        internal TextBox reportsTo;
        internal TextBox notes;
        internal TextBox hireDate;
        internal TextBox birthDate;
        internal TextBox titleOfCourtesy;
        internal TextBox title;
        internal TextBox lastName;
        internal TextBox firstName;
    }
}