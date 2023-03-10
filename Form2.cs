using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Security.Policy;

namespace C__Database
{
    public partial class Form2 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Form2()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=db_zeamart;User=root; Password=;Port=3306"); ;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

           cmd = new MySqlCommand();
           con.Open();
           cmd.Connection = con;
           cmd.CommandText = "SELECT * FROM login where username='" + t_username.Text + "' AND password='" + t_password.Text + "'";
           dr = cmd.ExecuteReader();
           if (dr.Read())
           {
                this.Hide();
                Form1 home = new Form1();
                home.ShowDialog();
                this.Close(); // Test lah

           } else
           {
                MessageBox.Show("Invalid Login");
           }
           con.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            t_username.Text = "";
            t_password.Text = "";
        }
    }
}
