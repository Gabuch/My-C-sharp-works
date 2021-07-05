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
    public partial class LogicUser : Form
    {
       // OleDbConnection con;
        public LogicUser()
        {
            InitializeComponent();
           /* con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\SANEK\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\Info.mdb");
            OleDbCommand command = new OleDbCommand();
            con.Open();
            command.Connection = con;

            string str = "SELECT Role FROM S WHERE Role = 3 and Logina = '" + Log + "'";
            // string str2 = "SELECT Role FROM S WHERE Role = 2 and Logina = '" + Log + "'";

            command.CommandText = str;
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                button1.Visible = true;
                MessageBox.Show("Admin");
            }
            else { }      */          
        }

        private void LogicUser_Load(object sender, EventArgs e)
        {

        }
    }
}
