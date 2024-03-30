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
    public partial class AdminPanel : MetroFramework.Forms.MetroForm
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sotr sm = new Sotr();
            sm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Addusers sm = new Addusers();
            sm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zakazi sm = new Zakazi();
            sm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setsmena sm = new setsmena();
            sm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Smeni sm = new Smeni();
            sm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Uvolit sm = new Uvolit();
            sm.ShowDialog();
        }
    }
}
