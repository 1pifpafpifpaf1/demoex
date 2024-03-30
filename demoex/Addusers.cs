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
using MySql.Data.MySqlClient;

namespace demoex
{
    public partial class Addusers : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();
        public Addusers()
        {
            InitializeComponent();
        }

        private void Addusers_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            DB.OpenConnection();
            string name = Convert.ToString(logtext.Text);
            string password = Convert.ToString(passtext.Text);
            string work = "Работает";
            string role = rolebox.Text;
            int role1 = 0;
            if(role == "Официант") 
            {
                role1 = 2;
            }
            else if(role == "Повор") 
            {
                role1 = 3;
            }
            string adduser = $"INSERT INTO users (login, password, role, work) VALUES ('{name}', '{password}','{role1}','{work}')";
            MySqlCommand command = new MySqlCommand(adduser, DB.getConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено");
            DB.CloseConnection();
        }
    }
}
