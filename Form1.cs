using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace ProjektKawiarka
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HK5PHBI7;Initial Catalog=KawiarkaDB;Integrated Security=True;");
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            btCoffeeSmall.Enabled = false;
            btCoffeAverage.Enabled = false;
            btCoffeeBig.Enabled = false;
        }
        public int isEnoughWater() //wyciągniecie ilości wody z pliku txt
            {     
            string woda = File.ReadAllText(@"C:\Users\pawel\source\repos\ProjektKawiarka\woda.txt", Encoding.UTF8);
            string wodaa = woda;
            int WodaInt = System.Convert.ToInt32(wodaa);
            return WodaInt;
            }

        public void WaterDecrease(int k) //odjęcie k-wody z zbiornika z wodą\w pliku txt
        {
            string woda = File.ReadAllText(@"C:\Users\pawel\source\repos\ProjektKawiarka\woda.txt", Encoding.UTF8);
            string wodaa = woda;
            int WodaInt = System.Convert.ToInt32(wodaa);
            int NewWater = WodaInt - k;
            string WriteWater = NewWater.ToString();
            File.WriteAllText(@"C:\Users\pawel\source\repos\ProjektKawiarka\woda.txt", WriteWater);
        }

        public void GiveCoffe()
        {
            lbGiveCoffee.Text = "Kawa Wydana";
        }

        public int MoneyWallet;
        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            var WaterLevel = isEnoughWater();
            lbWalletAmount.Text = txbMoney.Text+" pln"; //Wpisanie do portfela ilosci pieniedzy
            string txbMoneyAmount = txbMoney.Text;
            int MoneyAmount = Int16.Parse(txbMoneyAmount); //Konwertowanie pieniedzy na inta
            if (MoneyAmount >= 3 && WaterLevel > 1)
            {
                btCoffeeSmall.Enabled = true;
            }
            if (MoneyAmount >= 5 && WaterLevel > 1)
            {
                btCoffeAverage.Enabled = true;
            }
            if (MoneyAmount >= 7 && WaterLevel > 1)
            {
                btCoffeeBig.Enabled = true;
            }
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

        public void MoneyDecrease(int k)
        {
            string txbMoneyAmount = txbMoney.Text;
            int MoneyAmount = Int32.Parse(txbMoneyAmount); //Konwertowanie pieniedzy na inta
            int NewMoney = MoneyAmount - k;
            lbWalletAmount.Text = NewMoney.ToString();
        }

        public void btCoffeeSmall_Click(object sender, EventArgs e)
        {
            string size = "Mała kawa";
            con.Open();
            cmd = new SqlCommand("insert into transakcje values('" + size + "','" + 3 + "')",con);
            cmd.ExecuteNonQuery();
            con.Close();

            MoneyDecrease(3);
            WaterDecrease(3);

            string txbMoneyAmount = txbMoney.Text;
            int MoneyAmount = Int16.Parse(txbMoneyAmount); //Konwertowanie pieniedzy na inta
            var WaterLevel = isEnoughWater();
            if (MoneyAmount <= 3 && WaterLevel > 5)
            {
                btCoffeeBig.Enabled = false;
                btCoffeAverage.Enabled = false;
                btCoffeeSmall.Enabled = false;
            }

            GiveCoffe();
        }

        private void btCoffeAverage_Click(object sender, EventArgs e)
        {
            string size = "Średnia kawa";
            con.Open();
            cmd = new SqlCommand("insert into transakcje values('" + size + "','" + 5 + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            MoneyDecrease(5);
            WaterDecrease(5);

            string txbMoneyAmount = txbMoney.Text;
            int MoneyAmount = Int16.Parse(txbMoneyAmount); //Konwertowanie pieniedzy na inta
            var WaterLevel = isEnoughWater();
            if (MoneyAmount <= 5 && WaterLevel > 5)
            {
                btCoffeAverage.Enabled = false;
                btCoffeeBig.Enabled = false;
            }

            GiveCoffe();
        }

        private void btCoffeeBig_Click(object sender, EventArgs e)
        {
            string size = "Duża kawa";
            con.Open();
            cmd = new SqlCommand("insert into transakcje values('" + size + "','" + 7 + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            MoneyDecrease(7);
            WaterDecrease(7);

            string txbMoneyAmount = txbMoney.Text;
            int MoneyAmount = Int16.Parse(txbMoneyAmount); //Konwertowanie pieniedzy na inta
            var WaterLevel = isEnoughWater();
            if (MoneyAmount <= 7 && WaterLevel > 5)
            {
                btCoffeeBig.Enabled = false;
            }

            GiveCoffe();
        }
    }
}
