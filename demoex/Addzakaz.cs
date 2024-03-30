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
    public partial class Addzakaz : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();
        public Addzakaz()
        {
            InitializeComponent();
        }

        private void Addzakaz_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            DB.OpenConnection();
            int stolic = Convert.ToInt32(stolikbox.SelectedItem);
            int kolvo = Convert.ToInt32(kolvobox.SelectedItem);
            string opisanie = opisanietext.Text;
            string status = "Принят";
            DateTime data1 = DateTime.Now;
            var data = data1.ToString("yyyy-MM-dd H:mm:ss");
            string zakazi = $"INSERT INTO zakazi (stol, kolvo, data, opisanie, status) VALUES ('{stolic}','{kolvo}','{data}','{opisanie}','{status}')";
            MySqlCommand command = new MySqlCommand(zakazi, DB.getConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено");
            DB.CloseConnection();
        }
    }
}
