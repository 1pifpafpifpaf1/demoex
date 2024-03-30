using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoex
{
    public partial class changestatus : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();
        public changestatus()
        {
            InitializeComponent();
        }

        private void changestatus_Load(object sender, EventArgs e)
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
            nomerbox.DataSource = list_eq_table;
            nomerbox.DisplayMember = "id";
            nomerbox.ValueMember = "id";
            //Формируем строку запроса на отображение списка статусов прав пользователя
            string sql_list_users = $"SELECT id FROM zakazi";
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
            int id = Convert.ToInt32(nomerbox.SelectedValue);
            string status = Convert.ToString(statusbox.SelectedItem);
            string update = $"UPDATE zakazi SET status = '{status}' WHERE id = {id}";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(update, DB.getConnection());
            // выполняем запрос
            command.ExecuteNonQuery();
            DB.CloseConnection();
            MessageBox.Show("Статус изменен");
        }
    }
}
