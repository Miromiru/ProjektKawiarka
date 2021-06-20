
namespace ProjektKawiarka
{
    partial class loginmenu
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
            this.lbpassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Location = new System.Drawing.Point(155, 71);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(136, 20);
            this.lbpassword.TabIndex = 0;
            this.lbpassword.Text = "Podaj kod dostępu:";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(171, 118);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(101, 27);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPassword_KeyPress);
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(171, 167);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(101, 31);
            this.btnPassword.TabIndex = 2;
            this.btnPassword.Text = "Zaloguj";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // loginmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 276);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lbpassword);
            this.Name = "loginmenu";
            this.Text = "loginmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnPassword;
    }
}