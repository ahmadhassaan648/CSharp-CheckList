namespace CheckList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            chcsharp = new CheckBox();
            chjava = new CheckBox();
            chpyt = new CheckBox();
            chdsa = new CheckBox();
            chdbms = new CheckBox();
            choop = new CheckBox();
            chweb = new CheckBox();
            button1 = new Button();
            chcpp = new CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lbldatetime = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Stencil", 16F);
            label1.Location = new Point(166, 9);
            label1.Name = "label1";
            label1.Size = new Size(493, 40);
            label1.TabIndex = 0;
            label1.Text = "Books Borrowing Checklist";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(40, 126);
            label2.Name = "label2";
            label2.Size = new Size(398, 27);
            label2.TabIndex = 1;
            label2.Text = "Select the books you want from the following:";
            // 
            // chcsharp
            // 
            chcsharp.AutoSize = true;
            chcsharp.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chcsharp.Location = new Point(103, 178);
            chcsharp.Name = "chcsharp";
            chcsharp.Size = new Size(234, 29);
            chcsharp.TabIndex = 2;
            chcsharp.Text = "C# Programming Basics";
            chcsharp.UseVisualStyleBackColor = true;
            // 
            // chjava
            // 
            chjava.AutoSize = true;
            chjava.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chjava.Location = new Point(467, 178);
            chjava.Name = "chjava";
            chjava.Size = new Size(192, 29);
            chjava.TabIndex = 3;
            chjava.Text = "Java Programming";
            chjava.UseVisualStyleBackColor = true;
            // 
            // chpyt
            // 
            chpyt.AutoSize = true;
            chpyt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chpyt.Location = new Point(103, 238);
            chpyt.Name = "chpyt";
            chpyt.Size = new Size(215, 29);
            chpyt.TabIndex = 4;
            chpyt.Text = "Python for Beginners";
            chpyt.UseVisualStyleBackColor = true;
            chpyt.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // chdsa
            // 
            chdsa.AutoSize = true;
            chdsa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chdsa.Location = new Point(467, 238);
            chdsa.Name = "chdsa";
            chdsa.Size = new Size(294, 29);
            chdsa.TabIndex = 5;
            chdsa.Text = "Data Structure And Algorithms";
            chdsa.UseVisualStyleBackColor = true;
            // 
            // chdbms
            // 
            chdbms.AutoSize = true;
            chdbms.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chdbms.Location = new Point(103, 293);
            chdbms.Name = "chdbms";
            chdbms.Size = new Size(345, 29);
            chdbms.TabIndex = 6;
            chdbms.Text = "Database Management System (SQL)";
            chdbms.UseVisualStyleBackColor = true;
            // 
            // choop
            // 
            choop.AutoSize = true;
            choop.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            choop.Location = new Point(467, 293);
            choop.Name = "choop";
            choop.Size = new Size(293, 29);
            choop.TabIndex = 7;
            choop.Text = "Object Oriented Programming";
            choop.UseVisualStyleBackColor = true;
            // 
            // chweb
            // 
            chweb.AutoSize = true;
            chweb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chweb.Location = new Point(103, 348);
            chweb.Name = "chweb";
            chweb.Size = new Size(326, 29);
            chweb.TabIndex = 8;
            chweb.Text = "Web Development (HTML, CSS, JS)";
            chweb.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(352, 409);
            button1.Name = "button1";
            button1.Size = new Size(161, 40);
            button1.TabIndex = 9;
            button1.Text = "Check Results";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // chcpp
            // 
            chcpp.AutoSize = true;
            chcpp.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chcpp.Location = new Point(467, 348);
            chcpp.Name = "chcpp";
            chcpp.Size = new Size(317, 29);
            chcpp.TabIndex = 10;
            chcpp.Text = "C++ Programming Fundamentals";
            chcpp.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // lbldatetime
            // 
            lbldatetime.AutoSize = true;
            lbldatetime.Location = new Point(449, 61);
            lbldatetime.Name = "lbldatetime";
            lbldatetime.Size = new Size(0, 25);
            lbldatetime.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(812, 452);
            Controls.Add(lbldatetime);
            Controls.Add(chcpp);
            Controls.Add(button1);
            Controls.Add(chweb);
            Controls.Add(choop);
            Controls.Add(chdbms);
            Controls.Add(chdsa);
            Controls.Add(chpyt);
            Controls.Add(chjava);
            Controls.Add(chcsharp);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox chcsharp;
        private CheckBox chjava;
        private CheckBox chpyt;
        private CheckBox chdsa;
        private CheckBox chdbms;
        private CheckBox choop;
        private CheckBox chweb;
        private Button button1;
        private CheckBox chcpp;
        private System.Windows.Forms.Timer timer1;
        private Label lbldatetime;
    }
}
