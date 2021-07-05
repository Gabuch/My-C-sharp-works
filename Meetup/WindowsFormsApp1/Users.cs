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
    public partial class Users : Form
    {
        
        public string CmdText = "SELECT * FROM Users ";
        public string VuvodOrg = "SELECT ";
        public string ConnString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\SANEK\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\Info.mdb";
        public Users()
        {
            InitializeComponent();
            OleDbDataAdapter dA = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dA.Fill(ds, "Users");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку полностью!", "Ошибка");
                return;
            }

            //Запомним выбранную строку
            int index = dataGridView1.SelectedRows[0].Index;
            if (dataGridView1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Выберите заполненную строку!", "Внимание");
                    return; }
            else
            {
                //Считаем данные
                string Role = dataGridView1.Rows[index].Cells[4].Value.ToString();
            

                //Создаем соеденение
                string connectionString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\SANEK\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\Info.mdb";//строка соеденения
                OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаем соеденение

                //Выполянем запрос к БД
                dbConnection.Open();//открываем соеденение
                string query = "DELETE FROM Users WHERE Role = " + Role;//строка запроса
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);//команда
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить данного пользователя?", "Удалить пользователя", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else

                //Выполняем запрос
               
                
                    MessageBox.Show("Данные удалены!", "Внимание!");
                    //Удаляем данные из таблицы в форме
                    dataGridView1.Rows.RemoveAt(index);
                

                //Закрываем соеденение с БД
                dbConnection.Close();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            OleDbDataAdapter dA = new OleDbDataAdapter(CmdText, ConnString); //обновление таблицы
            DataSet ds = new DataSet();
            dA.Fill(ds, "S");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }
    }

}