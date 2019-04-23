using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Common;

namespace database_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void buttonplus_Click(object sender, EventArgs e)
        {
            var mysqlConnection = new MySqlConnection("user id=root;" +
                                                      "password=;" +
                                                      "server=localhost;" +
                                                      "database=testwinkel;" +
                                                      "connection timeout=5");
            mysqlConnection.Open();
            var leesaantaltomaat = "SELECT aantal from testwinkel WHERE id = 1";
            var leesaantaltomaatcommand = new MySqlCommand(leesaantaltomaat, mysqlConnection);
            var reader = leesaantaltomaatcommand.ExecuteScalar().ToString();
            int reader1 = Convert.ToInt32(reader);
            MessageBox.Show(reader);
            mysqlConnection.Close();

            System.Threading.Thread.Sleep(500);

            mysqlConnection.Open();
            var databasecommand = "UPDATE `testwinkel` SET aantal = " + (reader1+1) + " where id = 1";
            var id = new MySqlCommand(databasecommand, mysqlConnection);
            id.ExecuteNonQuery();
            MessageBox.Show(databasecommand);
            mysqlConnection.Close();
        }
    }
}
