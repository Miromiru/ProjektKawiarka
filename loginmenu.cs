using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektKawiarka
{
    public partial class loginmenu : Form
    {
        public loginmenu()
        {
            InitializeComponent();
            // Set to no text.
            txbPassword.Text = "";
            // The password character is an asterisk.
            txbPassword.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txbPassword.MaxLength = 4;
        }

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        public string passwordcode = "2137";
        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text == passwordcode)
            {

                AdminPanel AdminForm = new AdminPanel();
                AdminForm.Show();
            }
            this.Close();
        }

    }
}
