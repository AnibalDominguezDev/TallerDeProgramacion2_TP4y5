using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_tp4 : Form
    {
        public Form_tp4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb_Desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void tb_Hasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btn_GenerarFuncion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Desde.Text.Trim()))
            {
                errorProvider1.SetError(tb_Desde, "Este campo es requerido");
                return;
            }

            if (string.IsNullOrEmpty(tb_Hasta.Text.Trim()))
            {
                errorProvider1.SetError(tb_Hasta, "Este campo es requerido");
                return;
            }

            listBox.Items.Clear();
            chart1.Series[0].Points.Clear();

            int desde = Int32.Parse(tb_Desde.Text);

            int hasta = Int32.Parse(tb_Hasta.Text);

            for (int i = desde; i <= hasta; i++)
            { 
                listBox.Items.Add(i.ToString());
                chart1.Series[0].Points.AddXY(i,i);
            }
        }

        private void btn_Pares_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Desde.Text.Trim()))
            {
                errorProvider1.SetError(tb_Desde, "Este campo es requerido");
                return;
            }

            if (string.IsNullOrEmpty(tb_Hasta.Text.Trim()))
            {
                errorProvider1.SetError(tb_Hasta, "Este campo es requerido");
                return;
            }

            listBox.Items.Clear();
            chart1.Series[0].Points.Clear();

            int desde = Int32.Parse(tb_Desde.Text);

            int hasta = Int32.Parse(tb_Hasta.Text);

            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 == 0)
                {
                    listBox.Items.Add(i.ToString());
                    chart1.Series[0].Points.AddXY(i, i);
                }
            }

        }

        private void btn_Impares_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tb_Desde.Text.Trim()))
            {
                errorProvider1.SetError(tb_Desde, "Este campo es requerido");
                return;
            }

            if (string.IsNullOrEmpty(tb_Hasta.Text.Trim()))
            {
                errorProvider1.SetError(tb_Hasta, "Este campo es requerido");
                return;
            }

            listBox.Items.Clear();
            chart1.Series[0].Points.Clear();

            int desde = Int32.Parse(tb_Desde.Text);

            int hasta = Int32.Parse(tb_Hasta.Text);

            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 != 0)
                {
                    listBox.Items.Add(i.ToString());
                    chart1.Series[0].Points.AddXY(i, i);
                }
            }
        }

        private void btn_Primos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Desde.Text.Trim()))
            {
                errorProvider1.SetError(tb_Desde, "Este campo es requerido");
                return;
            }

            if (string.IsNullOrEmpty(tb_Hasta.Text.Trim()))
            {
                errorProvider1.SetError(tb_Hasta, "Este campo es requerido");
                return;
            }

            listBox.Items.Clear();
            chart1.Series[0].Points.Clear();

            int desde = Int32.Parse(tb_Desde.Text);

            int hasta = Int32.Parse(tb_Hasta.Text);

            for (int i = desde; i <= hasta; i++)
            {
                if (i <= 1) continue;
                if (i <= 3) 
                {
                    listBox.Items.Add(i.ToString());
                    chart1.Series[0].Points.AddXY(i, i);
                };

                if (i % 2 == 0 || i % 3 == 0) continue;
                  listBox.Items.Add(i.ToString());
                chart1.Series[0].Points.AddXY(i, i);


            }
        }
    }
}
