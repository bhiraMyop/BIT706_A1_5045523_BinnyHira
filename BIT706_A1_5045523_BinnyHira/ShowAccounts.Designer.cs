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
            this.lstAccInfo = new System.Windows.Forms.Label();
            this.btnGetAccount = new System.Windows.Forms.Button();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.showCustomers = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.buttonInterest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAccounts
            // 
            this.lstAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.ItemHeight = 16;
            this.lstAccounts.Location = new System.Drawing.Point(12, 35);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.ScrollAlwaysVisible = true;
            this.lstAccounts.Size = new System.Drawing.Size(305, 228);
            this.lstAccounts.TabIndex = 5;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(402, 9);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(131, 20);
            this.customerLabel.TabIndex = 6;
            this.customerLabel.Text = "Customer Details";
            // 
            // lstAccInfo
            // 
            this.lstAccInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAccInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAccInfo.Location = new System.Drawing.Point(406, 93);
            this.lstAccInfo.Name = "lstAccInfo";
            this.lstAccInfo.Size = new System.Drawing.Size(590, 71);
            this.lstAccInfo.TabIndex = 8;
            // 
            // btnGetAccount
            // 
            this.btnGetAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAccount.Location = new System.Drawing.Point(12, 269);
            this.btnGetAccount.Name = "btnGetAccount";
            this.btnGetAccount.Size = new System.Drawing.Size(136, 45);
            this.btnGetAccount.TabIndex = 9;
            this.btnGetAccount.Text = "Select Account";
            this.btnGetAccount.UseVisualStyleBackColor = true;
            this.btnGetAccount.Click += new System.EventHandler(this.btnGetAccount_Click);
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh2.Location = new System.Drawing.Point(171, 269);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(136, 45);
            this.btnRefresh2.TabIndex = 10;
            this.btnRefresh2.Text = "Refresh Display";
            this.btnRefresh2.UseVisualStyleBackColor = true;
            this.btnRefresh2.Click += new System.EventHandler(this.btnRefresh2_Click);
            // 
            // showCustomers
            // 
            this.showCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCustomers.Location = new System.Drawing.Point(38, 373);
            this.showCustomers.Name = "showCustomers";
            this.showCustomers.Size = new System.Drawing.Size(236, 45);
            this.showCustomers.TabIndex = 11;
            this.showCustomers.Text = "Show Customers";
            this.showCustomers.UseVisualStyleBackColor = true;
            // 
            // withdrawButton
            // 
            this.withdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawButton.Location = new System.Drawing.Point(406, 218);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(148, 45);
            this.withdrawButton.TabIndex = 12;
            this.withdrawButton.Text = "Withdraw Money";
            this.withdrawButton.UseVisualStyleBackColor = true;
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.Location = new System.Drawing.Point(635, 218);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(148, 45);
            this.depositButton.TabIndex = 13;
            this.depositButton.Text = "Deposit Money";
            this.depositButton.UseVisualStyleBackColor = true;
            // 
            // buttonInterest
            // 
            this.buttonInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInterest.Location = new System.Drawing.Point(848, 218);
            this.buttonInterest.Name = "buttonInterest";
            this.buttonInterest.Size = new System.Drawing.Size(148, 45);
            this.buttonInterest.TabIndex = 14;
            this.buttonInterest.Text = "Calculate Interest";
            this.buttonInterest.UseVisualStyleBackColor = true;
            // 
            // ShowAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 450);
            this.Controls.Add(this.buttonInterest);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.showCustomers);
            this.Controls.Add(this.btnRefresh2);
            this.Controls.Add(this.btnGetAccount);
            this.Controls.Add(this.lstAccInfo);
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
        private System.Windows.Forms.Label lstAccInfo;
        private System.Windows.Forms.Button btnGetAccount;
        private System.Windows.Forms.Button btnRefresh2;
        private System.Windows.Forms.Button showCustomers;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button buttonInterest;
    }
}