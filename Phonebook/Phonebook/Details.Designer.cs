namespace Phonebook
{
    partial class Details
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_email = new System.Windows.Forms.DataGridView();
            this.dataGridView_number = new System.Windows.Forms.DataGridView();
            this.dataGridView_address = new System.Windows.Forms.DataGridView();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_address)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(91, 12);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(210, 20);
            this.textBox_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // dataGridView_email
            // 
            this.dataGridView_email.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_email.Location = new System.Drawing.Point(24, 201);
            this.dataGridView_email.Name = "dataGridView_email";
            this.dataGridView_email.Size = new System.Drawing.Size(233, 94);
            this.dataGridView_email.TabIndex = 2;
            // 
            // dataGridView_number
            // 
            this.dataGridView_number.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_number.Location = new System.Drawing.Point(24, 66);
            this.dataGridView_number.Name = "dataGridView_number";
            this.dataGridView_number.Size = new System.Drawing.Size(233, 101);
            this.dataGridView_number.TabIndex = 3;
            // 
            // dataGridView_address
            // 
            this.dataGridView_address.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_address.Location = new System.Drawing.Point(273, 66);
            this.dataGridView_address.Name = "dataGridView_address";
            this.dataGridView_address.Size = new System.Drawing.Size(643, 229);
            this.dataGridView_address.TabIndex = 4;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(808, 338);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 5;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 393);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.dataGridView_address);
            this.Controls.Add(this.dataGridView_number);
            this.Controls.Add(this.dataGridView_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Details";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_address)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_email;
        private System.Windows.Forms.DataGridView dataGridView_number;
        private System.Windows.Forms.DataGridView dataGridView_address;
        private System.Windows.Forms.Button button_close;
    }
}