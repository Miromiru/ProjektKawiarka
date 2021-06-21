
namespace ProjektKawiarka
{
    partial class AdminPanel
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
            this.lbWater = new System.Windows.Forms.Label();
            this.lbWaterAmount = new System.Windows.Forms.Label();
            this.btnAddWater = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbTransactionsTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWater
            // 
            this.lbWater.AutoSize = true;
            this.lbWater.Location = new System.Drawing.Point(486, 17);
            this.lbWater.Name = "lbWater";
            this.lbWater.Size = new System.Drawing.Size(152, 20);
            this.lbWater.TabIndex = 0;
            this.lbWater.Text = "Ilość dostępnej wody:";
            // 
            // lbWaterAmount
            // 
            this.lbWaterAmount.AutoSize = true;
            this.lbWaterAmount.Location = new System.Drawing.Point(644, 17);
            this.lbWaterAmount.Name = "lbWaterAmount";
            this.lbWaterAmount.Size = new System.Drawing.Size(27, 20);
            this.lbWaterAmount.TabIndex = 1;
            this.lbWaterAmount.Text = "##";
            // 
            // btnAddWater
            // 
            this.btnAddWater.Location = new System.Drawing.Point(694, 13);
            this.btnAddWater.Name = "btnAddWater";
            this.btnAddWater.Size = new System.Drawing.Size(94, 29);
            this.btnAddWater.TabIndex = 2;
            this.btnAddWater.Text = "Uzupełnij wodę";
            this.btnAddWater.UseVisualStyleBackColor = true;
            this.btnAddWater.Click += new System.EventHandler(this.btnAddWater_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 390);
            this.dataGridView1.TabIndex = 3;
            // 
            // lbTransactionsTitle
            // 
            this.lbTransactionsTitle.AutoSize = true;
            this.lbTransactionsTitle.Location = new System.Drawing.Point(22, 22);
            this.lbTransactionsTitle.Name = "lbTransactionsTitle";
            this.lbTransactionsTitle.Size = new System.Drawing.Size(152, 20);
            this.lbTransactionsTitle.TabIndex = 4;
            this.lbTransactionsTitle.Text = "Dokonane Transakcje:\r\n";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTransactionsTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddWater);
            this.Controls.Add(this.lbWaterAmount);
            this.Controls.Add(this.lbWater);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWater;
        private System.Windows.Forms.Label lbWaterAmount;
        private System.Windows.Forms.Button btnAddWater;
        private System.Windows.Forms.Label lbTransactionsTitle;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}