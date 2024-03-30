using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Nevron.Nov.Chart;

namespace demoex
{
    public partial class Авторизация : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();
        public Авторизация()
        {
            InitializeComponent();
        }

        public int Connection(string login, string password)
        {


            DB.OpenConnection();
            //Выбор всех данных из таблицы staff и их фильтрование по подходящим логину и паролю
            string commandStr = $"SELECT * FROM users WHERE login = '{login}' AND password = '{password}'";
            MySqlCommand comm1 = new MySqlCommand(commandStr, DB.getConnection());
            int k = Convert.ToInt32(comm1.ExecuteScalar());
            // Выполнение SQL-запроса и получение количества записей, соответствующих запросу
            if (k != 0)
            {
                string commandStr2 = $"SELECT role FROM users WHERE login = '{login}' AND password = '{password}'";
                MySqlCommand comm2 = new MySqlCommand(commandStr2, DB.getConnection());
                Auth.auth_role = Convert.ToInt32(comm2.ExecuteScalar());
                string commandStr3 = $"SELECT id FROM users WHERE login = '{login}' AND password = '{password}'";
                MySqlCommand comm3 = new MySqlCommand(commandStr3, DB.getConnection());
                Auth.auth_id = Convert.ToInt32(comm3.ExecuteScalar());
                // Получение роли пользователя (auth_role) и его идентификатора (auth_id) из базы данных
            }

            //Закрытие соединения
            DB.CloseConnection();
            return Auth.auth_role & Auth.auth_id;
        }
        public void Rang()
        {

            if (Connection(logtext.Text, passtext.Text) == Auth.auth_role)
            {
                if (Auth.auth_role == 1) 
                {
                    MessageBox.Show($"Вы авторизированы как админ");
                    // Отображение сообщения с ролью пользователя после успешной авторизации
                    AdminPanel sm = new AdminPanel();
                    sm.ShowDialog();
                    // Открытие следующей формы
                }
                if (Auth.auth_role == 2) 
                {
                    MessageBox.Show($"Вы авторизированы как официант");
                    // Отображение сообщения с ролью пользователя после успешной авторизации
                    oficiant sm = new oficiant();
                    sm.ShowDialog();
                    // Открытие следующей формы
                }
                if (Auth.auth_role == 3)
                {
                    MessageBox.Show($"Вы авторизированы как повор");
                    // Отображение сообщения с ролью пользователя после успешной авторизации
                    Povar sm = new Povar();
                    sm.ShowDialog();
                    // Открытие следующей формы
                }
            }
            else
            {
                MessageBox.Show("Неверные данные");
                // Отображение сообщения об ошибке при неверных учетных данных
            }

        }
        private void Авторизация_Load(object sender, EventArgs e)
        {

        }

        private void logbutton_Click(object sender, EventArgs e)
        {
            string password = passtext.Text; // Применение хеширования к тексту в поле passtext при нажатии кнопки loginbutton
            Thread myThread1 = new Thread(Rang);
            myThread1.SetApartmentState(ApartmentState.STA);
            myThread1.Start(); // Создание и запуск нового потока для выполнения метода Rang
            this.Hide();// Скрытие текущей формы
        }
    }
}
