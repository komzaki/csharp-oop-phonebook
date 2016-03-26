namespace Phonebook
{
    partial class Form_Main
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_ContactNumber = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_contactnum = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.groupBox_address = new System.Windows.Forms.GroupBox();
            this.textBox_zip = new System.Windows.Forms.TextBox();
            this.label_zip = new System.Windows.Forms.Label();
            this.textBox_street = new System.Windows.Forms.TextBox();
            this.label_street = new System.Windows.Forms.Label();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.label_number = new System.Windows.Forms.Label();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.label_country = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.label_city = new System.Windows.Forms.Label();
            this.textBox_barangay = new System.Windows.Forms.TextBox();
            this.label_barangay = new System.Windows.Forms.Label();
            this.groupBox_details = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_view = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.groupBox_address.SuspendLayout();
            this.groupBox_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(60, 25);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name:";
            // 
            // label_ContactNumber
            // 
            this.label_ContactNumber.AutoSize = true;
            this.label_ContactNumber.Location = new System.Drawing.Point(34, 54);
            this.label_ContactNumber.Name = "label_ContactNumber";
            this.label_ContactNumber.Size = new System.Drawing.Size(64, 13);
            this.label_ContactNumber.TabIndex = 1;
            this.label_ContactNumber.Text = "Contact No.";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(41, 86);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(57, 13);
            this.label_Email.TabIndex = 2;
            this.label_Email.Text = "Email Add.";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(104, 22);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(132, 20);
            this.textBox_name.TabIndex = 3;
            // 
            // textBox_contactnum
            // 
            this.textBox_contactnum.Location = new System.Drawing.Point(104, 51);
            this.textBox_contactnum.Name = "textBox_contactnum";
            this.textBox_contactnum.Size = new System.Drawing.Size(132, 20);
            this.textBox_contactnum.TabIndex = 4;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(104, 83);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(132, 20);
            this.textBox_email.TabIndex = 5;
            // 
            // groupBox_address
            // 
            this.groupBox_address.Controls.Add(this.textBox_zip);
            this.groupBox_address.Controls.Add(this.label_zip);
            this.groupBox_address.Controls.Add(this.textBox_street);
            this.groupBox_address.Controls.Add(this.label_street);
            this.groupBox_address.Controls.Add(this.textBox_number);
            this.groupBox_address.Controls.Add(this.label_number);
            this.groupBox_address.Controls.Add(this.textBox_country);
            this.groupBox_address.Controls.Add(this.label_country);
            this.groupBox_address.Controls.Add(this.textBox_city);
            this.groupBox_address.Controls.Add(this.label_city);
            this.groupBox_address.Controls.Add(this.textBox_barangay);
            this.groupBox_address.Controls.Add(this.label_barangay);
            this.groupBox_address.Location = new System.Drawing.Point(24, 123);
            this.groupBox_address.Name = "groupBox_address";
            this.groupBox_address.Size = new System.Drawing.Size(226, 199);
            this.groupBox_address.TabIndex = 6;
            this.groupBox_address.TabStop = false;
            this.groupBox_address.Text = "Address";
            // 
            // textBox_zip
            // 
            this.textBox_zip.Location = new System.Drawing.Point(80, 149);
            this.textBox_zip.Name = "textBox_zip";
            this.textBox_zip.Size = new System.Drawing.Size(132, 20);
            this.textBox_zip.TabIndex = 18;
            // 
            // label_zip
            // 
            this.label_zip.AutoSize = true;
            this.label_zip.Location = new System.Drawing.Point(50, 152);
            this.label_zip.Name = "label_zip";
            this.label_zip.Size = new System.Drawing.Size(22, 13);
            this.label_zip.TabIndex = 17;
            this.label_zip.Text = "Zip";
            // 
            // textBox_street
            // 
            this.textBox_street.Location = new System.Drawing.Point(80, 123);
            this.textBox_street.Name = "textBox_street";
            this.textBox_street.Size = new System.Drawing.Size(132, 20);
            this.textBox_street.TabIndex = 16;
            // 
            // label_street
            // 
            this.label_street.AutoSize = true;
            this.label_street.Location = new System.Drawing.Point(39, 126);
            this.label_street.Name = "label_street";
            this.label_street.Size = new System.Drawing.Size(35, 13);
            this.label_street.TabIndex = 15;
            this.label_street.Text = "Street";
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(80, 97);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(132, 20);
            this.textBox_number.TabIndex = 14;
            this.textBox_number.Text = "1";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(30, 100);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(44, 13);
            this.label_number.TabIndex = 13;
            this.label_number.Text = "Number";
            // 
            // textBox_country
            // 
            this.textBox_country.Location = new System.Drawing.Point(80, 71);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(132, 20);
            this.textBox_country.TabIndex = 12;
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.Location = new System.Drawing.Point(31, 74);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(43, 13);
            this.label_country.TabIndex = 11;
            this.label_country.Text = "Country";
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(80, 45);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(132, 20);
            this.textBox_city.TabIndex = 10;
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(50, 48);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(24, 13);
            this.label_city.TabIndex = 9;
            this.label_city.Text = "City";
            // 
            // textBox_barangay
            // 
            this.textBox_barangay.Location = new System.Drawing.Point(80, 19);
            this.textBox_barangay.Name = "textBox_barangay";
            this.textBox_barangay.Size = new System.Drawing.Size(132, 20);
            this.textBox_barangay.TabIndex = 8;
            // 
            // label_barangay
            // 
            this.label_barangay.AutoSize = true;
            this.label_barangay.Location = new System.Drawing.Point(22, 22);
            this.label_barangay.Name = "label_barangay";
            this.label_barangay.Size = new System.Drawing.Size(52, 13);
            this.label_barangay.TabIndex = 7;
            this.label_barangay.Text = "Barangay";
            // 
            // groupBox_details
            // 
            this.groupBox_details.Controls.Add(this.label_name);
            this.groupBox_details.Controls.Add(this.groupBox_address);
            this.groupBox_details.Controls.Add(this.label_ContactNumber);
            this.groupBox_details.Controls.Add(this.textBox_email);
            this.groupBox_details.Controls.Add(this.label_Email);
            this.groupBox_details.Controls.Add(this.textBox_contactnum);
            this.groupBox_details.Controls.Add(this.textBox_name);
            this.groupBox_details.Location = new System.Drawing.Point(22, 20);
            this.groupBox_details.Name = "groupBox_details";
            this.groupBox_details.Size = new System.Drawing.Size(303, 341);
            this.groupBox_details.TabIndex = 7;
            this.groupBox_details.TabStop = false;
            this.groupBox_details.Text = "Contact Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Phonebook";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(43, 376);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 316);
            this.dataGridView1.TabIndex = 11;
            // 
            // button_view
            // 
            this.button_view.Location = new System.Drawing.Point(515, 376);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(75, 23);
            this.button_view.TabIndex = 12;
            this.button_view.Text = "View";
            this.button_view.UseVisualStyleBackColor = true;
            this.button_view.Click += new System.EventHandler(this.button_view_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(422, 376);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 430);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button_view);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox_details);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonebook";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox_address.ResumeLayout(false);
            this.groupBox_address.PerformLayout();
            this.groupBox_details.ResumeLayout(false);
            this.groupBox_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_ContactNumber;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_contactnum;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.GroupBox groupBox_address;
        private System.Windows.Forms.TextBox textBox_zip;
        private System.Windows.Forms.Label label_zip;
        private System.Windows.Forms.TextBox textBox_street;
        private System.Windows.Forms.Label label_street;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.TextBox textBox_country;
        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.TextBox textBox_barangay;
        private System.Windows.Forms.Label label_barangay;
        private System.Windows.Forms.GroupBox groupBox_details;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_view;
        private System.Windows.Forms.Button Delete;
    }
}

