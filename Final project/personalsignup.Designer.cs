
namespace Final_project
{
    partial class personalsignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personalsignup));
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Adresstext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IDtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Firstnametxt = new System.Windows.Forms.TextBox();
            this.AcNAme = new System.Windows.Forms.Label();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Investment = new System.Windows.Forms.RadioButton();
            this.Checking = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Phonetxt
            // 
            this.Phonetxt.Location = new System.Drawing.Point(208, 325);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(100, 20);
            this.Phonetxt.TabIndex = 36;
            this.Phonetxt.TextChanged += new System.EventHandler(this.Phonetxt_TextChanged);
            this.Phonetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Phonetxt_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Phone Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(208, 260);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(100, 20);
            this.Emailtxt.TabIndex = 34;
            this.Emailtxt.Leave += new System.EventHandler(this.Emailtxt_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Azure;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Adresstext
            // 
            this.Adresstext.Location = new System.Drawing.Point(208, 200);
            this.Adresstext.Name = "Adresstext";
            this.Adresstext.Size = new System.Drawing.Size(100, 20);
            this.Adresstext.TabIndex = 32;
            this.Adresstext.TextChanged += new System.EventHandler(this.Adresstext_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // IDtext
            // 
            this.IDtext.Location = new System.Drawing.Point(208, 144);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(100, 20);
            this.IDtext.TabIndex = 30;
            this.IDtext.TextChanged += new System.EventHandler(this.IDtext_TextChanged);
            this.IDtext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IDtext_KeyDown);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Address";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Firstnametxt
            // 
            this.Firstnametxt.Location = new System.Drawing.Point(208, 40);
            this.Firstnametxt.Name = "Firstnametxt";
            this.Firstnametxt.Size = new System.Drawing.Size(100, 20);
            this.Firstnametxt.TabIndex = 28;
            this.Firstnametxt.TextChanged += new System.EventHandler(this.Firstnametxt_TextChanged);
            this.Firstnametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Firstnametxt_KeyDown);
            // 
            // AcNAme
            // 
            this.AcNAme.AutoSize = true;
            this.AcNAme.BackColor = System.Drawing.Color.Azure;
            this.AcNAme.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcNAme.Location = new System.Drawing.Point(47, 40);
            this.AcNAme.Name = "AcNAme";
            this.AcNAme.Size = new System.Drawing.Size(75, 20);
            this.AcNAme.TabIndex = 27;
            this.AcNAme.Text = "First Name";
            this.AcNAme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AcNAme.Click += new System.EventHandler(this.AcNAme_Click);
            // 
            // lastnametxt
            // 
            this.lastnametxt.Location = new System.Drawing.Point(208, 89);
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(100, 20);
            this.lastnametxt.TabIndex = 38;
            this.lastnametxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.lastnametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastnametxt_KeyDown);
            this.lastnametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastnametxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Last Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Investment
            // 
            this.Investment.BackColor = System.Drawing.Color.Azure;
            this.Investment.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Investment.Location = new System.Drawing.Point(498, 183);
            this.Investment.Name = "Investment";
            this.Investment.Size = new System.Drawing.Size(194, 51);
            this.Investment.TabIndex = 40;
            this.Investment.TabStop = true;
            this.Investment.Text = "Investment Account";
            this.Investment.UseVisualStyleBackColor = false;
            // 
            // Checking
            // 
            this.Checking.BackColor = System.Drawing.Color.Azure;
            this.Checking.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checking.Location = new System.Drawing.Point(498, 89);
            this.Checking.Name = "Checking";
            this.Checking.Size = new System.Drawing.Size(194, 55);
            this.Checking.TabIndex = 39;
            this.Checking.TabStop = true;
            this.Checking.Text = "Checking Account ";
            this.Checking.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(498, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 74);
            this.button2.TabIndex = 42;
            this.button2.Text = "create account";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // personalsignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Investment);
            this.Controls.Add(this.Checking);
            this.Controls.Add(this.lastnametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phonetxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Adresstext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Firstnametxt);
            this.Controls.Add(this.AcNAme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "personalsignup";
            this.ShowInTaskbar = false;
            this.Text = "Personal sign up";
            this.Load += new System.EventHandler(this.personalsignup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Adresstext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Firstnametxt;
        private System.Windows.Forms.Label AcNAme;
        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Investment;
        private System.Windows.Forms.RadioButton Checking;
        private System.Windows.Forms.Button button2;
    }
}