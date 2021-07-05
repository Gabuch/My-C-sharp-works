using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Konf : Form
    {
        OleDbConnection con;
        public string CmdText = "SELECT * FROM Conferenc";
        public string ConnString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\SANEK\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\Info.mdb";
        public Boolean CheckUser()
        {
            OleDbCommand comm = new OleDbCommand();
            string ConnectionString = (@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\SANEK\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\Info.mdb");
            OleDbConnection con = new OleDbConnection(ConnectionString);
            con.Open();
            comm.CommandText = @"SELECT COUNT (*) FROM Users Where Logina = '" + textBox2.Text + "'";
            comm.Connection = con;
            int count = (int)comm.ExecuteScalar(); //вернет количество записей
            if (count > 0) //проверяем
            {
                return false;
            }
            else
            {
                return true;
            }
            con.Close();
        }
        public Konf()
        {
            InitializeComponent();
            OleDbDataAdapter dA = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dA.Fill(ds, "Conferenc");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Konf_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Введите данные в поля"); //проверка на пустую ячейку
                textBox1.Clear();
                textBox2.Clear();
                return;
            }
            else
                con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\SANEK\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\Info.mdb");
            OleDbCommand command = new OleDbCommand();

            command.Connection = con;
            string str = "INSERT INTO Связь (Login, ID_CONF, ACCEPT) VALUES ('" + textBox2.Text + "', " + textBox1.Text + ", 0 )";
            con.Open();
            if (CheckUser())
            {
                MessageBox.Show("Такой логин не существует, введите свой");
                textBox1.Clear();
                textBox2.Clear();
                return;
            }
            else
            {
                command.CommandText = str;
                if (command.ExecuteNonQuery() != 1)
                    MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                else
                    MessageBox.Show("Данные добавлены!", "Внимание!");
                con.Close();
                this.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
