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
    public partial class Avtorisation : Form
    {
        OleDbConnection con;
        public Avtorisation()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {}
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Login.Text) || String.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Введите данные в поля");          //проверка на пустую ячейку
                return;
            }
            else
            {
                con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\SANEK\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\Info.mdb");
                OleDbCommand command = new OleDbCommand();
                con.Open();
                command.Connection = con;

                string str = "SELECT * FROM Users WHERE Logina='" + Login.Text + "' AND Passworda='" + Password.Text + "'";
                command.CommandText = str;
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    
                    MessageBox.Show("Добро пожаловать " + Login.Text);
                    string Log = Login.Text;
                    Menu f3 = new Menu(Log);                    
                    f3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                    Login.Clear();
                    Password.Clear();
                    return;
                }
                con.Close();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {}
        private void textBox2_TextChanged(object sender, EventArgs e)
        {}
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}