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
    public partial class Form2 : Form
    {
        OleDbConnection con;
        public Boolean CheckUser()
        {
            OleDbCommand comm = new OleDbCommand();
            string ConnectionString = (@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\SANEK\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\Info.mdb");
            OleDbConnection con = new OleDbConnection(ConnectionString);
            con.Open();
            comm.CommandText = @"SELECT COUNT (*) FROM Users Where Logina = '" + log.Text + "'";
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
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(log.Text) || String.IsNullOrEmpty(pass.Text))
            {
                MessageBox.Show("Введите данные в поля"); //проверка на пустую ячейку
                log.Clear();
                pass.Clear();
                return;
            }
            else
                con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\SANEK\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\Info.mdb");
            OleDbCommand command = new OleDbCommand();
            
            command.Connection = con;
            string str = "INSERT INTO Users (Logina, Passworda, Role, Who, Oblast) VALUES ('" + log.Text + "','" + pass.Text + "' , '1', '" + Namesa.Text + "', '" + Oblast.Text + "')";
            con.Open();
            if (!CheckUser())
            {
                MessageBox.Show("Такой логин уже существует, введите другой");
                log.Clear();
                pass.Clear();
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

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
