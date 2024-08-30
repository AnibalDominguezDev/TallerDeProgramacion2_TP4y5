using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.TP5
{
    public partial class Form_tp5 : Form
    {
        public Form_tp5()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Apellido.Text))
            {
                errorProvider1.SetError(tb_Apellido, "Este campo es requerido");
                return;
            }
            else if (string.IsNullOrEmpty(tb_Nombre.Text))
            {
                errorProvider1.SetError(tb_Nombre, "Este campo es requerido");
                return;
            }
            else if (string.IsNullOrEmpty(tb_Saldo.Text))
            {
                errorProvider1.SetError(tb_Saldo, "Este campo es requerido");
                return;
            }

            string sexo = "";

            if (rb_sexoHombre.Checked)
            {
                sexo = rb_sexoHombre.Text;
            } else
            {
                sexo = rb_sexoMujer.Text;
            }


            dg_resultado.Rows.Add(tb_Apellido.Text, tb_Nombre.Text,dp_FechaNacimiento.Value,sexo,"Eliminar", tb_Saldo.Text, "foto", tb_FotoPath.Text);

            if (Int32.Parse(tb_Saldo.Text) < 50) dg_resultado.Rows[dg_resultado.Rows.Count - 2].DefaultCellStyle.BackColor = Color.FromArgb(255, 102, 102);

            try
            {
                dg_resultado.Rows[dg_resultado.Rows.Count - 2].Cells[6].Value = Image.FromFile(tb_FotoPath.Text);
            }
            catch (Exception)
            {

                dg_resultado.Rows[dg_resultado.Rows.Count - 2].Cells[6].Value = Properties.Resources.errorImage;
            }


            //System.IO.File.Copy(tb_FotoPath.Text,);


        }

        private void btn_Foto_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

             if (openFileDialog1.ShowDialog() == DialogResult.OK) tb_FotoPath.Text = openFileDialog1.FileName;

            try
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            catch (Exception)
            {
                pictureBox1.Image = Properties.Resources.errorImage;
            }
           
        }

        private void tb_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void tb_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void tb_Saldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void dg_resultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_resultado.Rows.Count > 1)
            {
                var result = MessageBox.Show("Seguro que desea Eliminar al usuario?", "Eliminar usuario",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

                if (result == DialogResult.Yes) dg_resultado.Rows.RemoveAt(e.RowIndex);

            } else
            {
                return;
            }
        }
    }
}
