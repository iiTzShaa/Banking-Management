
namespace Final_project
{
    partial class managerform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managerform));
            this.AccountsGridView = new System.Windows.Forms.DataGridView();
            this.Business = new System.Windows.Forms.RadioButton();
            this.Personal = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IDtext = new System.Windows.Forms.TextBox();
            this.deleteaccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountsGridView
            // 
            this.AccountsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsGridView.Location = new System.Drawing.Point(5, 155);
            this.AccountsGridView.Name = "AccountsGridView";
            this.AccountsGridView.Size = new System.Drawing.Size(576, 283);
            this.AccountsGridView.TabIndex = 0;
            this.AccountsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Business
            // 
            this.Business.AutoSize = true;
            this.Business.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Business.Location = new System.Drawing.Point(31, 79);
            this.Business.Name = "Business";
            this.Business.Size = new System.Drawing.Size(79, 24);
            this.Business.TabIndex = 61;
            this.Business.TabStop = true;
            this.Business.Text = "Business";
            this.Business.UseVisualStyleBackColor = true;
            // 
            // Personal
            // 
            this.Personal.AutoSize = true;
            this.Personal.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Personal.Location = new System.Drawing.Point(140, 79);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(81, 24);
            this.Personal.TabIndex = 60;
            this.Personal.TabStop = true;
            this.Personal.Text = "Personal";
            this.Personal.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(297, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 52);
            this.button2.TabIndex = 59;
            this.button2.Text = "All Accounts";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(299, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 51);
            this.button1.TabIndex = 58;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "ID";
            // 
            // IDtext
            // 
            this.IDtext.Location = new System.Drawing.Point(71, 27);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(150, 20);
            this.IDtext.TabIndex = 56;
            this.IDtext.TextChanged += new System.EventHandler(this.IDtext_TextChanged);
            // 
            // deleteaccount
            // 
            this.deleteaccount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteaccount.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteaccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteaccount.Location = new System.Drawing.Point(612, 55);
            this.deleteaccount.Name = "deleteaccount";
            this.deleteaccount.Size = new System.Drawing.Size(157, 57);
            this.deleteaccount.TabIndex = 62;
            this.deleteaccount.Text = "delete account";
            this.deleteaccount.UseVisualStyleBackColor = false;
            this.deleteaccount.Click += new System.EventHandler(this.deleteaccount_Click);
            // 
            // managerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteaccount);
            this.Controls.Add(this.Business);
            this.Controls.Add(this.Personal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDtext);
            this.Controls.Add(this.AccountsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "managerform";
            this.Text = "managerform";
            this.Load += new System.EventHandler(this.managerform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AccountsGridView;
        private System.Windows.Forms.RadioButton Business;
        private System.Windows.Forms.RadioButton Personal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDtext;
        private System.Windows.Forms.Button deleteaccount;
    }
}