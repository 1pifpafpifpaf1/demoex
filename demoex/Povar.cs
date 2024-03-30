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
    public partial class Povar : MetroFramework.Forms.MetroForm
    {
        public Povar()
        {
            InitializeComponent();
        }

        private void Povar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            statuschange2 sm = new statuschange2();
            sm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zakazi sm = new Zakazi();
            sm.ShowDialog();
        }
    }
}
