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
    public partial class AdminPanel : Form
    {

        public AdminPanel()
        {
            InitializeComponent();
            string ReadWater = File.ReadAllText(@"C:\Users\pawel\source\repos\ProjektKawiarka\woda.txt", Encoding.UTF8);
            lbWaterAmount.Text = ReadWater;

            var select = "SELECT * FROM transakcje";
            var c = new SqlConnection(@"Data Source=LAPTOP-HK5PHBI7;Initial Catalog=KawiarkaDB;Integrated Security=True;");
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnAddWater_Click(object sender, EventArgs e)
        {
            string WriteWater = "100";
            File.WriteAllText(@"C:\Users\pawel\source\repos\ProjektKawiarka\woda.txt", WriteWater);
            lbWaterAmount.Text = WriteWater;
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
