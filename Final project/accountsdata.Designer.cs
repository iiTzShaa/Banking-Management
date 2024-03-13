
namespace Final_project
{
    partial class accountsdata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accountsdata));
            this.label3 = new System.Windows.Forms.Label();
            this.IDtext = new System.Windows.Forms.TextBox();
            this.AccountsGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Depositbutton = new System.Windows.Forms.Button();
            this.Withdrawbutton = new System.Windows.Forms.Button();
            this.Depositamount = new System.Windows.Forms.Label();
            this.Deposittxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Personal = new System.Windows.Forms.RadioButton();
            this.Business = new System.Windows.Forms.RadioButton();
            this.Investammount = new System.Windows.Forms.TextBox();
            this.InvestmentAmount = new System.Windows.Forms.Label();
            this.Invest = new System.Windows.Forms.Button();
            this.Months = new System.Windows.Forms.TextBox();
            this.years = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // IDtext
            // 
            this.IDtext.Location = new System.Drawing.Point(65, 32);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(150, 20);
            this.IDtext.TabIndex = 41;
            this.IDtext.TextChanged += new System.EventHandler(this.IDtext_TextChanged);
            this.IDtext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IDtext_KeyDown);
            // 
            // AccountsGridView
            // 
            this.AccountsGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.AccountsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.AccountsGridView.Location = new System.Drawing.Point(12, 172);
            this.AccountsGridView.Name = "AccountsGridView";
            this.AccountsGridView.Size = new System.Drawing.Size(643, 347);
            this.AccountsGridView.TabIndex = 45;
            this.AccountsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(19, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 45);
            this.button1.TabIndex = 46;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Depositbutton
            // 
            this.Depositbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Depositbutton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depositbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Depositbutton.Location = new System.Drawing.Point(318, 111);
            this.Depositbutton.Name = "Depositbutton";
            this.Depositbutton.Size = new System.Drawing.Size(112, 45);
            this.Depositbutton.TabIndex = 47;
            this.Depositbutton.Text = "Deposit";
            this.Depositbutton.UseVisualStyleBackColor = false;
            this.Depositbutton.Click += new System.EventHandler(this.Depositbutton_Click);
            // 
            // Withdrawbutton
            // 
            this.Withdrawbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Withdrawbutton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdrawbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Withdrawbutton.Location = new System.Drawing.Point(458, 112);
            this.Withdrawbutton.Name = "Withdrawbutton";
            this.Withdrawbutton.Size = new System.Drawing.Size(112, 45);
            this.Withdrawbutton.TabIndex = 48;
            this.Withdrawbutton.Text = "Withdraw";
            this.Withdrawbutton.UseVisualStyleBackColor = false;
            this.Withdrawbutton.Click += new System.EventHandler(this.Withdrawbutton_Click);
            // 
            // Depositamount
            // 
            this.Depositamount.AutoSize = true;
            this.Depositamount.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depositamount.Location = new System.Drawing.Point(326, 30);
            this.Depositamount.Name = "Depositamount";
            this.Depositamount.Size = new System.Drawing.Size(104, 20);
            this.Depositamount.TabIndex = 49;
            this.Depositamount.Text = "Deposit Amount";
            this.Depositamount.Click += new System.EventHandler(this.label2_Click);
            // 
            // Deposittxt
            // 
            this.Deposittxt.Location = new System.Drawing.Point(451, 32);
            this.Deposittxt.Name = "Deposittxt";
            this.Deposittxt.Size = new System.Drawing.Size(119, 20);
            this.Deposittxt.TabIndex = 50;
            this.Deposittxt.TextChanged += new System.EventHandler(this.Deposittxt_TextChanged);
            this.Deposittxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Deposittxt_KeyDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(149, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 46);
            this.button2.TabIndex = 51;
            this.button2.Text = "All Accounts";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // withdraw
            // 
            this.withdraw.Location = new System.Drawing.Point(451, 64);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(119, 20);
            this.withdraw.TabIndex = 53;
            this.withdraw.TextChanged += new System.EventHandler(this.withdraw_TextChanged);
            this.withdraw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.withdraw_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Withdraw Amount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Personal
            // 
            this.Personal.AutoSize = true;
            this.Personal.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Personal.Location = new System.Drawing.Point(170, 67);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(81, 24);
            this.Personal.TabIndex = 54;
            this.Personal.TabStop = true;
            this.Personal.Text = "Personal";
            this.Personal.UseVisualStyleBackColor = true;
            this.Personal.CheckedChanged += new System.EventHandler(this.Personal_CheckedChanged);
            // 
            // Business
            // 
            this.Business.AutoSize = true;
            this.Business.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Business.Location = new System.Drawing.Point(65, 66);
            this.Business.Name = "Business";
            this.Business.Size = new System.Drawing.Size(79, 24);
            this.Business.TabIndex = 55;
            this.Business.TabStop = true;
            this.Business.Text = "Business";
            this.Business.UseVisualStyleBackColor = true;
            this.Business.CheckedChanged += new System.EventHandler(this.Business_CheckedChanged);
            // 
            // Investammount
            // 
            this.Investammount.Location = new System.Drawing.Point(783, 34);
            this.Investammount.Name = "Investammount";
            this.Investammount.Size = new System.Drawing.Size(100, 20);
            this.Investammount.TabIndex = 57;
            // 
            // InvestmentAmount
            // 
            this.InvestmentAmount.AutoSize = true;
            this.InvestmentAmount.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvestmentAmount.Location = new System.Drawing.Point(641, 34);
            this.InvestmentAmount.Name = "InvestmentAmount";
            this.InvestmentAmount.Size = new System.Drawing.Size(125, 20);
            this.InvestmentAmount.TabIndex = 56;
            this.InvestmentAmount.Text = "Investment Amount";
            this.InvestmentAmount.Click += new System.EventHandler(this.InvestmentAmount_Click);
            // 
            // Invest
            // 
            this.Invest.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Invest.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Invest.Location = new System.Drawing.Point(636, 111);
            this.Invest.Name = "Invest";
            this.Invest.Size = new System.Drawing.Size(107, 45);
            this.Invest.TabIndex = 58;
            this.Invest.Text = "Invest";
            this.Invest.UseVisualStyleBackColor = false;
            this.Invest.Click += new System.EventHandler(this.Invest_Click);
            // 
            // Months
            // 
            this.Months.Location = new System.Drawing.Point(783, 69);
            this.Months.Name = "Months";
            this.Months.Size = new System.Drawing.Size(100, 20);
            this.Months.TabIndex = 60;
            this.Months.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // years
            // 
            this.years.AutoSize = true;
            this.years.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.years.Location = new System.Drawing.Point(641, 67);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(115, 20);
            this.years.TabIndex = 59;
            this.years.Text = "Number Of Years";
            this.years.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Calculate.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Calculate.Location = new System.Drawing.Point(783, 112);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(107, 45);
            this.Calculate.TabIndex = 61;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(741, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 57);
            this.button3.TabIndex = 62;
            this.button3.Text = "Clear Table";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Save.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Save.Location = new System.Drawing.Point(741, 315);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(122, 57);
            this.Save.TabIndex = 63;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            this.Save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Save_KeyDown);
            // 
            // Load
            // 
            this.Load.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Load.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Load.Location = new System.Drawing.Point(741, 406);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(122, 55);
            this.Load.TabIndex = 64;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // accountsdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 531);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Months);
            this.Controls.Add(this.years);
            this.Controls.Add(this.Invest);
            this.Controls.Add(this.Investammount);
            this.Controls.Add(this.InvestmentAmount);
            this.Controls.Add(this.Business);
            this.Controls.Add(this.Personal);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Deposittxt);
            this.Controls.Add(this.Depositamount);
            this.Controls.Add(this.Withdrawbutton);
            this.Controls.Add(this.Depositbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AccountsGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDtext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "accountsdata";
            this.Text = "Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDtext;
        private System.Windows.Forms.DataGridView AccountsGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Depositbutton;
        private System.Windows.Forms.Button Withdrawbutton;
        private System.Windows.Forms.Label Depositamount;
        private System.Windows.Forms.TextBox Deposittxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox withdraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Personal;
        private System.Windows.Forms.RadioButton Business;
        private System.Windows.Forms.TextBox Investammount;
        private System.Windows.Forms.Label InvestmentAmount;
        private System.Windows.Forms.Button Invest;
        private System.Windows.Forms.TextBox Months;
        private System.Windows.Forms.Label years;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
    }
}