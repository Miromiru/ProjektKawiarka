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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            lbWalletAmount.Text = txbMoney.Text+" pln"; //Wpisanie do portfela ilosci pieniedzy

            string txbMoneyAmount = txbMoney.Text;
            int MoneyAmount = Int16.Parse(txbMoneyAmount); //Konwertowanie pieniedzy na inta

        }

        private void txbMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnToAdminPanel_Click(object sender, EventArgs e)
        {
            loginmenu LoginForm = new loginmenu();
            LoginForm.Show();
        }
    }
}
