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
        }

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {

        }

    }
}
