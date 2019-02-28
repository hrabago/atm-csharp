namespace ATM
{
    partial class TaskPage
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
            this.viewBalance = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.depositFunds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "What transaction do you want to perfom today?";
            // 
            // viewBalance
            // 
            this.viewBalance.BackColor = System.Drawing.Color.Gold;
            this.viewBalance.Location = new System.Drawing.Point(307, 192);
            this.viewBalance.Name = "viewBalance";
            this.viewBalance.Size = new System.Drawing.Size(169, 41);
            this.viewBalance.TabIndex = 2;
            this.viewBalance.Text = "View Account Balance";
            this.viewBalance.UseVisualStyleBackColor = false;
            this.viewBalance.Click += new System.EventHandler(this.viewBalance_Click);
            // 
            // withdraw
            // 
            this.withdraw.BackColor = System.Drawing.Color.Gold;
            this.withdraw.Location = new System.Drawing.Point(307, 270);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(169, 41);
            this.withdraw.TabIndex = 3;
            this.withdraw.Text = "Withdraw";
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // depositFunds
            // 
            this.depositFunds.BackColor = System.Drawing.Color.Gold;
            this.depositFunds.Location = new System.Drawing.Point(307, 342);
            this.depositFunds.Name = "depositFunds";
            this.depositFunds.Size = new System.Drawing.Size(169, 42);
            this.depositFunds.TabIndex = 4;
            this.depositFunds.Text = "Deposit Funds";
            this.depositFunds.UseVisualStyleBackColor = false;
            this.depositFunds.Click += new System.EventHandler(this.depositFunds_Click);
            // 
            // TaskPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.depositFunds);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.viewBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaskPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TaskPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewBalance;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button depositFunds;
    }
}