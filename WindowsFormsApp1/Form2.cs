using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.TP5;

namespace WindowsFormsApp1
{
    public partial class Form_Inicial : Form
    {
        public Form_Inicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form_tp4().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form_tp5().ShowDialog();
        }
    }
}
