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

namespace demoex
{
    public partial class setsmena : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();
        public setsmena()
        {
            InitializeComponent();
        }

        private void setsmena_Load(object sender, EventArgs e)
        {
            GetComboBoxList();
        }

        void GetComboBoxList()
        {
            //Формирование списка статусов
            DataTable list_eq_table = new DataTable();
            MySqlCommand list_stud_command = new MySqlCommand();
            //Открываем соединение
            DB.OpenConnection();
            //Формируем столбцы для комбобокса списка ЦП
            list_eq_table.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            //Настройка видимости полей комбобокса
            workerbox.DataSource = list_eq_table;
            workerbox.DisplayMember = "id";
            workerbox.ValueMember = "id";
            //Формируем строку запроса на отображение списка статусов прав пользователя
            string sql_list_users = $"SELECT id FROM users";
            list_stud_command.CommandText = sql_list_users;
            list_stud_command.Connection = DB.getConnection();
            //Формирование списка ЦП для combobox'a
            MySqlDataReader list_eq_reader;
            try
            {
                //Инициализируем ридер
                list_eq_reader = list_stud_command.ExecuteReader();
                while (list_eq_reader.Read())
                {
                    DataRow rowToAdd = list_eq_table.NewRow();
                    rowToAdd["id"] = Convert.ToInt32(list_eq_reader[0]);
                    list_eq_table.Rows.Add(rowToAdd);
                }
                list_eq_reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения списка ЦП \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                DB.CloseConnection();
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            DB.OpenConnection();
            string id = Convert.ToString(workerbox.SelectedValue);
            string day = Convert.ToString(daybox.SelectedItem);
            string adduser = $"INSERT INTO smena (id_user, day) VALUES ('{id}', '{day}')";
            MySqlCommand command = new MySqlCommand(adduser, DB.getConnection());
            command.ExecuteNonQuery();
            DB.CloseConnection();
            MessageBox.Show("Смена добавлена");
        }
    }
}
