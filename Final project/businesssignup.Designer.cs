
namespace Final_project
{
    partial class businesssignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(businesssignup));
            this.AcNAme = new System.Windows.Forms.Label();
            this.Compnyname = new System.Windows.Forms.TextBox();
            this.IDtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Adresstext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Checking = new System.Windows.Forms.RadioButton();
            this.Investment = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // AcNAme
            // 
            this.AcNAme.BackColor = System.Drawing.Color.Azure;
            this.AcNAme.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcNAme.Location = new System.Drawing.Point(66, 39);
            this.AcNAme.Name = "AcNAme";
            this.AcNAme.Size = new System.Drawing.Size(133, 39);
            this.AcNAme.TabIndex = 15;
            this.AcNAme.Text = "Company Name";
            this.AcNAme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Compnyname
            // 
            this.Compnyname.Location = new System.Drawing.Point(276, 39);
            this.Compnyname.Name = "Compnyname";
            this.Compnyname.Size = new System.Drawing.Size(100, 20);
            this.Compnyname.TabIndex = 16;
            this.Compnyname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Compnyname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Compnyname_KeyDown);
            // 
            // IDtext
            // 
            this.IDtext.Location = new System.Drawing.Point(276, 94);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(100, 20);
            this.IDtext.TabIndex = 20;
            this.IDtext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IDtext_KeyDown);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "Address";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 34);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Adresstext
            // 
            this.Adresstext.Location = new System.Drawing.Point(276, 145);
            this.Adresstext.Name = "Adresstext";
            this.Adresstext.Size = new System.Drawing.Size(100, 20);
            this.Adresstext.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Azure;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 41);
            this.label4.TabIndex = 23;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(276, 212);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(100, 20);
            this.Emailtxt.TabIndex = 24;
            this.Emailtxt.TextChanged += new System.EventHandler(this.Emailtxt_TextChanged);
            this.Emailtxt.Leave += new System.EventHandler(this.Emailtxt_Leave);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(67, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 36);
            this.label5.TabIndex = 25;
            this.label5.Text = "Phone Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Phonetxt
            // 
            this.Phonetxt.Location = new System.Drawing.Point(276, 275);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(100, 20);
            this.Phonetxt.TabIndex = 26;
            this.Phonetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Phonetxt_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(551, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 82);
            this.button1.TabIndex = 27;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Checking
            // 
            this.Checking.BackColor = System.Drawing.Color.Azure;
            this.Checking.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checking.Location = new System.Drawing.Point(543, 72);
            this.Checking.Name = "Checking";
            this.Checking.Size = new System.Drawing.Size(154, 56);
            this.Checking.TabIndex = 28;
            this.Checking.TabStop = true;
            this.Checking.Text = "Checking Account ";
            this.Checking.UseVisualStyleBackColor = false;
            this.Checking.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Investment
            // 
            this.Investment.BackColor = System.Drawing.Color.Azure;
            this.Investment.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Investment.Location = new System.Drawing.Point(543, 186);
            this.Investment.Name = "Investment";
            this.Investment.Size = new System.Drawing.Size(153, 57);
            this.Investment.TabIndex = 29;
            this.Investment.TabStop = true;
            this.Investment.Text = "Investment Account";
            this.Investment.UseVisualStyleBackColor = false;
            // 
            // businesssignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Investment);
            this.Controls.Add(this.Checking);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Phonetxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Adresstext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Compnyname);
            this.Controls.Add(this.AcNAme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "businesssignup";
            this.Text = "Business signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AcNAme;
        private System.Windows.Forms.TextBox Compnyname;
        private System.Windows.Forms.TextBox IDtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Adresstext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Checking;
        private System.Windows.Forms.RadioButton Investment;
        public System.Windows.Forms.TextBox Emailtxt;
    }
}