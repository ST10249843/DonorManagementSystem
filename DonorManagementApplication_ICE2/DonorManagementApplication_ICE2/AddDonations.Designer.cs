namespace DonorManagementApplication_ICE2
{
    partial class AddDonations
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
            this.labelDonorName = new System.Windows.Forms.Label();
            this.labelDonorAmount = new System.Windows.Forms.Label();
            this.labelDonationDate = new System.Windows.Forms.Label();
            this.labelCause = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(172, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donor Management System";
            // 
            // labelDonorName
            // 
            this.labelDonorName.AutoSize = true;
            this.labelDonorName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonorName.Location = new System.Drawing.Point(121, 106);
            this.labelDonorName.Name = "labelDonorName";
            this.labelDonorName.Size = new System.Drawing.Size(116, 21);
            this.labelDonorName.TabIndex = 1;
            this.labelDonorName.Text = "Donor Name:";
            // 
            // labelDonorAmount
            // 
            this.labelDonorAmount.AutoSize = true;
            this.labelDonorAmount.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonorAmount.Location = new System.Drawing.Point(121, 171);
            this.labelDonorAmount.Name = "labelDonorAmount";
            this.labelDonorAmount.Size = new System.Drawing.Size(128, 21);
            this.labelDonorAmount.TabIndex = 2;
            this.labelDonorAmount.Text = "Donor Amount:";
            // 
            // labelDonationDate
            // 
            this.labelDonationDate.AutoSize = true;
            this.labelDonationDate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonationDate.Location = new System.Drawing.Point(121, 293);
            this.labelDonationDate.Name = "labelDonationDate";
            this.labelDonationDate.Size = new System.Drawing.Size(130, 21);
            this.labelDonationDate.TabIndex = 3;
            this.labelDonationDate.Text = "Donation Date:";
            // 
            // labelCause
            // 
            this.labelCause.AutoSize = true;
            this.labelCause.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCause.Location = new System.Drawing.Point(121, 236);
            this.labelCause.Name = "labelCause";
            this.labelCause.Size = new System.Drawing.Size(67, 21);
            this.labelCause.TabIndex = 4;
            this.labelCause.Text = "Cause:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(263, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 22);
            this.textBox2.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(263, 293);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(263, 237);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 22);
            this.textBox3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddDonations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelCause);
            this.Controls.Add(this.labelDonationDate);
            this.Controls.Add(this.labelDonorAmount);
            this.Controls.Add(this.labelDonorName);
            this.Controls.Add(this.label1);
            this.Name = "AddDonations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDonations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDonorName;
        private System.Windows.Forms.Label labelDonorAmount;
        private System.Windows.Forms.Label labelDonationDate;
        private System.Windows.Forms.Label labelCause;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}