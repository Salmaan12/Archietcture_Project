namespace bankingApplication
{
    partial class Selection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerbtn = new System.Windows.Forms.Button();
            this.Adminbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO ABC BANKING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ONLINE BANKING DESKTOP APPLICATION";
            // 
            // customerbtn
            // 
            this.customerbtn.Location = new System.Drawing.Point(410, 240);
            this.customerbtn.Name = "customerbtn";
            this.customerbtn.Size = new System.Drawing.Size(158, 43);
            this.customerbtn.TabIndex = 4;
            this.customerbtn.Text = "CUSTOMER/USER";
            this.customerbtn.UseVisualStyleBackColor = true;
            this.customerbtn.Click += new System.EventHandler(this.customerbtn_Click);
            // 
            // Adminbtn
            // 
            this.Adminbtn.Location = new System.Drawing.Point(410, 191);
            this.Adminbtn.Name = "Adminbtn";
            this.Adminbtn.Size = new System.Drawing.Size(158, 43);
            this.Adminbtn.TabIndex = 5;
            this.Adminbtn.Text = "ADMIN/BANK";
            this.Adminbtn.UseVisualStyleBackColor = true;
            this.Adminbtn.Click += new System.EventHandler(this.Adminbtn_Click);
            // 
            // selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.Adminbtn);
            this.Controls.Add(this.customerbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "selection";
            this.Text = "selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button customerbtn;
        private System.Windows.Forms.Button Adminbtn;
    }
}