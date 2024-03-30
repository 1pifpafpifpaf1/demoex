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
    public partial class oficiant : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();
        public oficiant()
        {
            InitializeComponent();
        }

        private void oficiant_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Addzakaz sm = new Addzakaz();
            sm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zakazi sm = new Zakazi();
            sm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changestatus sm = new changestatus();
            sm.ShowDialog();
        }
    }
}
