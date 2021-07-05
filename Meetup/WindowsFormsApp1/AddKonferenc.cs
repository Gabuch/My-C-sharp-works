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
    public partial class AddKonferenc : Form
    {
        OleDbConnection con;
        public string CmdText = "SELECT * FROM Conferenc";
        public string ConnString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\SANEK\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\Info.mdb";
        public AddKonferenc()
        {
            InitializeComponent();
            OleDbDataAdapter dA = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dA.Fill(ds, "Conferenc");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Введите данные в поля"); //проверка на пустую ячейку
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();
                return;
            }
            else
            {

                string connectionString = (@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\SANEK\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\Info.mdb");//строка соеденения
                OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаем соединение
                OleDbCommand command = new OleDbCommand();
                dbConnection.Open();
                command.Connection = dbConnection;
                string str = "INSERT INTO Conferenc (Namesa, Vida, Address, Web_sait, Data) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')";

                command.CommandText = str;
                if (command.ExecuteNonQuery() != 1)
                    MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                else
                    MessageBox.Show("Данные добавлены!", "Внимание!");
                dbConnection.Close();
                OleDbDataAdapter dA = new OleDbDataAdapter(CmdText, ConnString); //обновление таблицы
                DataSet ds = new DataSet();
                dA.Fill(ds, "Conferenc");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void Names_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
