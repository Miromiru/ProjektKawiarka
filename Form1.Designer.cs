
namespace ProjektKawiarka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAddMoney = new System.Windows.Forms.Label();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.btnToAdminPanel = new System.Windows.Forms.Button();
            this.lbClientWallet = new System.Windows.Forms.Label();
            this.lbWalletAmount = new System.Windows.Forms.Label();
            this.lbCoffeeSmall = new System.Windows.Forms.Label();
            this.lbCoffeAverage = new System.Windows.Forms.Label();
            this.lbCoffeBig = new System.Windows.Forms.Label();
            this.btCoffeeSmall = new System.Windows.Forms.Button();
            this.btCoffeAverage = new System.Windows.Forms.Button();
            this.btCoffeeBig = new System.Windows.Forms.Button();
            this.lbGiveCoffee = new System.Windows.Forms.Label();
            this.txbMoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbAddMoney
            // 
            this.lbAddMoney.AutoSize = true;
            this.lbAddMoney.Location = new System.Drawing.Point(56, 57);
            this.lbAddMoney.Name = "lbAddMoney";
            this.lbAddMoney.Size = new System.Drawing.Size(105, 20);
            this.lbAddMoney.TabIndex = 1;
            this.lbAddMoney.Text = "Wrzuć monetę";
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.Location = new System.Drawing.Point(56, 137);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(109, 35);
            this.btnAddMoney.TabIndex = 2;
            this.btnAddMoney.Text = "Doładuj";
            this.btnAddMoney.UseVisualStyleBackColor = true;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // btnToAdminPanel
            // 
            this.btnToAdminPanel.Location = new System.Drawing.Point(12, 401);
            this.btnToAdminPanel.Name = "btnToAdminPanel";
            this.btnToAdminPanel.Size = new System.Drawing.Size(153, 37);
            this.btnToAdminPanel.TabIndex = 3;
            this.btnToAdminPanel.Text = "Panel Admina";
            this.btnToAdminPanel.UseVisualStyleBackColor = true;
            this.btnToAdminPanel.Click += new System.EventHandler(this.btnToAdminPanel_Click);
            // 
            // lbClientWallet
            // 
            this.lbClientWallet.AutoSize = true;
            this.lbClientWallet.Location = new System.Drawing.Point(419, 46);
            this.lbClientWallet.Name = "lbClientWallet";
            this.lbClientWallet.Size = new System.Drawing.Size(82, 20);
            this.lbClientWallet.TabIndex = 4;
            this.lbClientWallet.Text = "Stan konta:";
            // 
            // lbWalletAmount
            // 
            this.lbWalletAmount.AutoSize = true;
            this.lbWalletAmount.Location = new System.Drawing.Point(498, 46);
            this.lbWalletAmount.Name = "lbWalletAmount";
            this.lbWalletAmount.Size = new System.Drawing.Size(0, 20);
            this.lbWalletAmount.TabIndex = 5;
            // 
            // lbCoffeeSmall
            // 
            this.lbCoffeeSmall.AutoSize = true;
            this.lbCoffeeSmall.Location = new System.Drawing.Point(301, 100);
            this.lbCoffeeSmall.Name = "lbCoffeeSmall";
            this.lbCoffeeSmall.Size = new System.Drawing.Size(86, 40);
            this.lbCoffeeSmall.TabIndex = 6;
            this.lbCoffeeSmall.Text = "Mała Kawa \r\n- 3pln";
            // 
            // lbCoffeAverage
            // 
            this.lbCoffeAverage.AutoSize = true;
            this.lbCoffeAverage.Location = new System.Drawing.Point(451, 100);
            this.lbCoffeAverage.Name = "lbCoffeAverage";
            this.lbCoffeAverage.Size = new System.Drawing.Size(103, 40);
            this.lbCoffeAverage.TabIndex = 7;
            this.lbCoffeAverage.Text = "Średnia Kawa \r\n- 5pln";
            // 
            // lbCoffeBig
            // 
            this.lbCoffeBig.AutoSize = true;
            this.lbCoffeBig.Location = new System.Drawing.Point(597, 100);
            this.lbCoffeBig.Name = "lbCoffeBig";
            this.lbCoffeBig.Size = new System.Drawing.Size(83, 40);
            this.lbCoffeBig.TabIndex = 8;
            this.lbCoffeBig.Text = "Duża Kawa\r\n- 7 pln\r\n";
            // 
            // btCoffeeSmall
            // 
            this.btCoffeeSmall.Location = new System.Drawing.Point(301, 143);
            this.btCoffeeSmall.Name = "btCoffeeSmall";
            this.btCoffeeSmall.Size = new System.Drawing.Size(94, 29);
            this.btCoffeeSmall.TabIndex = 9;
            this.btCoffeeSmall.Text = "Zamów";
            this.btCoffeeSmall.UseVisualStyleBackColor = true;
            // 
            // btCoffeAverage
            // 
            this.btCoffeAverage.Location = new System.Drawing.Point(451, 143);
            this.btCoffeAverage.Name = "btCoffeAverage";
            this.btCoffeAverage.Size = new System.Drawing.Size(94, 29);
            this.btCoffeAverage.TabIndex = 10;
            this.btCoffeAverage.Text = "Zamów";
            this.btCoffeAverage.UseVisualStyleBackColor = true;
            // 
            // btCoffeeBig
            // 
            this.btCoffeeBig.Location = new System.Drawing.Point(597, 143);
            this.btCoffeeBig.Name = "btCoffeeBig";
            this.btCoffeeBig.Size = new System.Drawing.Size(94, 29);
            this.btCoffeeBig.TabIndex = 11;
            this.btCoffeeBig.Text = "Zamów";
            this.btCoffeeBig.UseVisualStyleBackColor = true;
            // 
            // lbGiveCoffee
            // 
            this.lbGiveCoffee.AutoSize = true;
            this.lbGiveCoffee.Location = new System.Drawing.Point(419, 350);
            this.lbGiveCoffee.Name = "lbGiveCoffee";
            this.lbGiveCoffee.Size = new System.Drawing.Size(122, 20);
            this.lbGiveCoffee.TabIndex = 12;
            this.lbGiveCoffee.Text = "Smacznej Kawusi";
            // 
            // txbMoney
            // 
            this.txbMoney.Location = new System.Drawing.Point(56, 97);
            this.txbMoney.Name = "txbMoney";
            this.txbMoney.Size = new System.Drawing.Size(125, 27);
            this.txbMoney.TabIndex = 13;
            this.txbMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMoney_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbMoney);
            this.Controls.Add(this.lbGiveCoffee);
            this.Controls.Add(this.btCoffeeBig);
            this.Controls.Add(this.btCoffeAverage);
            this.Controls.Add(this.btCoffeeSmall);
            this.Controls.Add(this.lbCoffeBig);
            this.Controls.Add(this.lbCoffeAverage);
            this.Controls.Add(this.lbCoffeeSmall);
            this.Controls.Add(this.lbWalletAmount);
            this.Controls.Add(this.lbClientWallet);
            this.Controls.Add(this.btnToAdminPanel);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.lbAddMoney);
            this.Name = "Form1";
            this.Text = "Automat do Kawy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbAddMoney;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Button btnToAdminPanel;
        private System.Windows.Forms.Label lbClientWallet;
        private System.Windows.Forms.Label lbWalletAmount;
        private System.Windows.Forms.Label lbCoffeeSmall;
        private System.Windows.Forms.Label lbCoffeAverage;
        private System.Windows.Forms.Label lbCoffeBig;
        private System.Windows.Forms.Button btCoffeeSmall;
        private System.Windows.Forms.Button btCoffeAverage;
        private System.Windows.Forms.Button btCoffeeBig;
        private System.Windows.Forms.Label lbGiveCoffee;
        private System.Windows.Forms.TextBox txbMoney;
    }
}

