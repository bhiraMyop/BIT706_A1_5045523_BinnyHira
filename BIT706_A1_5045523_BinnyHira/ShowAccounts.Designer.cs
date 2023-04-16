namespace BIT706_A1_5045523_BinnyHira
{
    partial class ShowAccounts
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
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstAccounts
            // 
            this.lstAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.ItemHeight = 16;
            this.lstAccounts.Location = new System.Drawing.Point(460, 12);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.ScrollAlwaysVisible = true;
            this.lstAccounts.Size = new System.Drawing.Size(212, 276);
            this.lstAccounts.TabIndex = 5;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(25, 12);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(131, 20);
            this.customerLabel.TabIndex = 6;
            this.customerLabel.Text = "Customer Details";
            // 
            // ShowAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.lstAccounts);
            this.Name = "ShowAccounts";
            this.Text = "ShowAccounts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAccounts;
        private System.Windows.Forms.Label customerLabel;
    }
}