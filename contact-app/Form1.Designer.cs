namespace contact_app
{
    partial class Form1
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
            this.outputbox = new System.Windows.Forms.GroupBox();
            this.inputbox = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.outputbox.SuspendLayout();
            this.inputbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputbox
            // 
            this.outputbox.BackColor = System.Drawing.SystemColors.Control;
            this.outputbox.Controls.Add(this.richTextBox2);
            this.outputbox.Location = new System.Drawing.Point(12, 12);
            this.outputbox.Name = "outputbox";
            this.outputbox.Size = new System.Drawing.Size(470, 426);
            this.outputbox.TabIndex = 0;
            this.outputbox.TabStop = false;
            // 
            // inputbox
            // 
            this.inputbox.BackColor = System.Drawing.Color.PapayaWhip;
            this.inputbox.Controls.Add(this.label5);
            this.inputbox.Controls.Add(this.searchbar);
            this.inputbox.Controls.Add(this.button2);
            this.inputbox.Controls.Add(this.button1);
            this.inputbox.Controls.Add(this.label4);
            this.inputbox.Controls.Add(this.address);
            this.inputbox.Controls.Add(this.label2);
            this.inputbox.Controls.Add(this.phone);
            this.inputbox.Controls.Add(this.label3);
            this.inputbox.Controls.Add(this.lastname);
            this.inputbox.Controls.Add(this.label1);
            this.inputbox.Controls.Add(this.name);
            this.inputbox.Location = new System.Drawing.Point(488, 12);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(300, 426);
            this.inputbox.TabIndex = 1;
            this.inputbox.TabStop = false;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(30, 130);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(255, 20);
            this.name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 114);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 168);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "فامیل:";
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(30, 184);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(255, 20);
            this.lastname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 227);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "تلفن:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(30, 243);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(255, 20);
            this.phone.TabIndex = 6;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(30, 300);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(255, 58);
            this.address.TabIndex = 8;
            this.address.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 284);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "نشانی:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Bisque;
            this.richTextBox2.Location = new System.Drawing.Point(22, 29);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(422, 376);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "جستجو";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "اضافه کردن";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchbar
            // 
            this.searchbar.Location = new System.Drawing.Point(120, 49);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(165, 20);
            this.searchbar.TabIndex = 12;
            this.searchbar.TextChanged += new System.EventHandler(this.searchbar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 29);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "جستجو:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.outputbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.outputbox.ResumeLayout(false);
            this.inputbox.ResumeLayout(false);
            this.inputbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox outputbox;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox inputbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchbar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
    }
}

