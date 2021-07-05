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
    public partial class Konferenc : Form
    {
        OleDbConnection con;
        public string CmdText = "SELECT * FROM Conferenc";
        public string ConnString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\SANEK\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\Info.mdb";
        public Konferenc()
        {
            InitializeComponent();
            OleDbDataAdapter dA = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dA.Fill(ds, "Conferenc");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            
            /*con.Open();
            command.Connection = con;
            string str = "SELECT Role  FROM S WHERE Role = 3 and Logina = '" + Log + "'";
            command.CommandText = str;
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                button2.Visible = true;
                MessageBox.Show("Администратор");
            }
            else
            {
                button2.Visible = false;
            }
            con.Close();*/
        }
        private void Konferenc_Load(object sender, EventArgs e)
        { }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
        private void button3_Click(object sender, EventArgs e)
        {
            Forma f5 = new Forma();
            f5.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            AddKonferenc add = new AddKonferenc();
            add.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
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
                return;
            }
            else
            {
                //Считаем данные
                string ID = dataGridView1.Rows[index].Cells[0].Value.ToString();
                //Создаем соеденение
                string connectionString = @"Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\Users\SANEK\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\Info.mdb";//строка соеденения
                OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаем соеденение

                //Выполянем запрос к БД
                dbConnection.Open();//открываем соеденение
                string query = "DELETE FROM Conferenc WHERE Role = " + ID;//строка запроса
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);//команда
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить выбранную конференцию?", "Удалить пользователя", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                    MessageBox.Show("Данные удалены!", "Внимание!");
                //Удаляем данные из таблицы в форме
                dataGridView1.Rows.RemoveAt(index);
                //Закрываем соеденение с БД
                dbConnection.Close();

            }
        }
    }
}
