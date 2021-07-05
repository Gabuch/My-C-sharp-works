using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        OleDbConnection con;
        public Menu(string Log)
        {

            InitializeComponent();
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\SANEK\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\Info.mdb");
            OleDbCommand command = new OleDbCommand();
            con.Open();
            command.Connection = con;

            string str = "SELECT Role FROM Users WHERE Role = 2 and Logina = '" + Log + "'";
            command.CommandText = str;
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                Adm1.Visible = true;
                Adm2.Visible = true;            //вывод кнопок для организатора
                Org1.Visible = true;
                Org2.Visible = true;
                MessageBox.Show("Admin");
            }
            else
                con.Close();
        }
        /*  command.CommandText = str2;

          if (reader.Read())
          {
              Org1.Visible = true;
              Org2.Visible = true;
              Adm1.Visible = false;
              Adm2.Visible = false;
          }
          else
          {
              MessageBox.Show("User");
          }*/
        private void Form3_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Users userss = new Users();
            userss.Show();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();             //закрытие программы полностью
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LogicUser logic = new LogicUser();
            logic.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Konf Konff = new Konf();
            Konff.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Konferenc Konf = new Konferenc();
            Konf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KonfOrganiz org = new KonfOrganiz();
            org.Show();
        }
    }
}

