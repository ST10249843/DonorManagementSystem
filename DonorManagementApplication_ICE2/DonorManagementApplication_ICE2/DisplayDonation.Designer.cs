namespace DonorManagementApplication_ICE2
{
    partial class DisplayDonation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DonorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Casue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(218, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Donor Management System";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DonorName,
            this.DonorAmount,
            this.DonationDate,
            this.Casue});
            this.dataGridView1.Location = new System.Drawing.Point(123, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // DonorName
            // 
            this.DonorName.HeaderText = "Donor Name";
            this.DonorName.MinimumWidth = 6;
            this.DonorName.Name = "DonorName";
            this.DonorName.Width = 125;
            // 
            // DonorAmount
            // 
            this.DonorAmount.HeaderText = "Donor Amount";
            this.DonorAmount.MinimumWidth = 6;
            this.DonorAmount.Name = "DonorAmount";
            this.DonorAmount.Width = 125;
            // 
            // DonationDate
            // 
            this.DonationDate.HeaderText = "DonationDate";
            this.DonationDate.MinimumWidth = 6;
            this.DonationDate.Name = "DonationDate";
            this.DonationDate.Width = 125;
            // 
            // Casue
            // 
            this.Casue.HeaderText = "Cause";
            this.Casue.MinimumWidth = 6;
            this.Casue.Name = "Casue";
            this.Casue.Width = 125;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(359, 371);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplayDonation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DisplayDonation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayDonation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Casue;
        private System.Windows.Forms.Button buttonBack;
    }
}