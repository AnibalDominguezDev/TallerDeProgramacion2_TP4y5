namespace WindowsFormsApp1.TP5
{
    partial class Form_tp5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.lb_Apellido = new System.Windows.Forms.Label();
            this.lb_FechaNacimiento = new System.Windows.Forms.Label();
            this.lb_Sexo = new System.Windows.Forms.Label();
            this.lb_Saldo = new System.Windows.Forms.Label();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.tb_Apellido = new System.Windows.Forms.TextBox();
            this.tb_Saldo = new System.Windows.Forms.TextBox();
            this.tb_FotoPath = new System.Windows.Forms.TextBox();
            this.dp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rb_sexoHombre = new System.Windows.Forms.RadioButton();
            this.rb_sexoMujer = new System.Windows.Forms.RadioButton();
            this.btn_Foto = new System.Windows.Forms.Button();
            this.dg_resultado = new System.Windows.Forms.DataGridView();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.col_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_resultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Agregar);
            this.panel1.Controls.Add(this.btn_Foto);
            this.panel1.Controls.Add(this.rb_sexoMujer);
            this.panel1.Controls.Add(this.rb_sexoHombre);
            this.panel1.Controls.Add(this.dp_FechaNacimiento);
            this.panel1.Controls.Add(this.tb_FotoPath);
            this.panel1.Controls.Add(this.tb_Saldo);
            this.panel1.Controls.Add(this.tb_Apellido);
            this.panel1.Controls.Add(this.tb_Nombre);
            this.panel1.Controls.Add(this.lb_Saldo);
            this.panel1.Controls.Add(this.lb_Sexo);
            this.panel1.Controls.Add(this.lb_FechaNacimiento);
            this.panel1.Controls.Add(this.lb_Apellido);
            this.panel1.Controls.Add(this.lb_Nombre);
            this.panel1.Location = new System.Drawing.Point(37, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 264);
            this.panel1.TabIndex = 0;
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nombre.Location = new System.Drawing.Point(25, 24);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(85, 25);
            this.lb_Nombre.TabIndex = 0;
            this.lb_Nombre.Text = "Nombre:";
            // 
            // lb_Apellido
            // 
            this.lb_Apellido.AutoSize = true;
            this.lb_Apellido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Apellido.Location = new System.Drawing.Point(25, 60);
            this.lb_Apellido.Name = "lb_Apellido";
            this.lb_Apellido.Size = new System.Drawing.Size(86, 25);
            this.lb_Apellido.TabIndex = 1;
            this.lb_Apellido.Text = "Apellido:";
            // 
            // lb_FechaNacimiento
            // 
            this.lb_FechaNacimiento.AutoSize = true;
            this.lb_FechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FechaNacimiento.Location = new System.Drawing.Point(25, 96);
            this.lb_FechaNacimiento.Name = "lb_FechaNacimiento";
            this.lb_FechaNacimiento.Size = new System.Drawing.Size(193, 25);
            this.lb_FechaNacimiento.TabIndex = 2;
            this.lb_FechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lb_Sexo
            // 
            this.lb_Sexo.AutoSize = true;
            this.lb_Sexo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sexo.Location = new System.Drawing.Point(25, 130);
            this.lb_Sexo.Name = "lb_Sexo";
            this.lb_Sexo.Size = new System.Drawing.Size(56, 25);
            this.lb_Sexo.TabIndex = 3;
            this.lb_Sexo.Text = "Sexo:";
            // 
            // lb_Saldo
            // 
            this.lb_Saldo.AutoSize = true;
            this.lb_Saldo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Saldo.Location = new System.Drawing.Point(25, 164);
            this.lb_Saldo.Name = "lb_Saldo";
            this.lb_Saldo.Size = new System.Drawing.Size(63, 25);
            this.lb_Saldo.TabIndex = 4;
            this.lb_Saldo.Text = "Saldo:";
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(116, 29);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(187, 20);
            this.tb_Nombre.TabIndex = 5;
            this.tb_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Nombre_KeyPress);
            // 
            // tb_Apellido
            // 
            this.tb_Apellido.Location = new System.Drawing.Point(116, 60);
            this.tb_Apellido.Name = "tb_Apellido";
            this.tb_Apellido.Size = new System.Drawing.Size(187, 20);
            this.tb_Apellido.TabIndex = 6;
            this.tb_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Apellido_KeyPress);
            // 
            // tb_Saldo
            // 
            this.tb_Saldo.Location = new System.Drawing.Point(116, 164);
            this.tb_Saldo.Name = "tb_Saldo";
            this.tb_Saldo.Size = new System.Drawing.Size(187, 20);
            this.tb_Saldo.TabIndex = 7;
            this.tb_Saldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Saldo_KeyPress);
            // 
            // tb_FotoPath
            // 
            this.tb_FotoPath.Location = new System.Drawing.Point(116, 200);
            this.tb_FotoPath.Name = "tb_FotoPath";
            this.tb_FotoPath.Size = new System.Drawing.Size(187, 20);
            this.tb_FotoPath.TabIndex = 8;
            // 
            // dp_FechaNacimiento
            // 
            this.dp_FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_FechaNacimiento.Location = new System.Drawing.Point(224, 99);
            this.dp_FechaNacimiento.Name = "dp_FechaNacimiento";
            this.dp_FechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dp_FechaNacimiento.TabIndex = 9;
            // 
            // rb_sexoHombre
            // 
            this.rb_sexoHombre.AutoSize = true;
            this.rb_sexoHombre.Checked = true;
            this.rb_sexoHombre.Location = new System.Drawing.Point(116, 137);
            this.rb_sexoHombre.Name = "rb_sexoHombre";
            this.rb_sexoHombre.Size = new System.Drawing.Size(62, 17);
            this.rb_sexoHombre.TabIndex = 10;
            this.rb_sexoHombre.TabStop = true;
            this.rb_sexoHombre.Text = "Hombre";
            this.rb_sexoHombre.UseVisualStyleBackColor = true;
            // 
            // rb_sexoMujer
            // 
            this.rb_sexoMujer.AutoSize = true;
            this.rb_sexoMujer.Location = new System.Drawing.Point(184, 137);
            this.rb_sexoMujer.Name = "rb_sexoMujer";
            this.rb_sexoMujer.Size = new System.Drawing.Size(51, 17);
            this.rb_sexoMujer.TabIndex = 11;
            this.rb_sexoMujer.Text = "Mujer";
            this.rb_sexoMujer.UseVisualStyleBackColor = true;
            // 
            // btn_Foto
            // 
            this.btn_Foto.Location = new System.Drawing.Point(30, 198);
            this.btn_Foto.Name = "btn_Foto";
            this.btn_Foto.Size = new System.Drawing.Size(75, 23);
            this.btn_Foto.TabIndex = 12;
            this.btn_Foto.Text = "Foto";
            this.btn_Foto.UseVisualStyleBackColor = true;
            this.btn_Foto.Click += new System.EventHandler(this.btn_Foto_Click);
            // 
            // dg_resultado
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_resultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_resultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_apellido,
            this.col_nombre,
            this.col_fechaNacimiento,
            this.col_sexo,
            this.col_eliminar,
            this.col_saldo,
            this.col_foto,
            this.col_ruta});
            this.dg_resultado.Location = new System.Drawing.Point(37, 295);
            this.dg_resultado.Name = "dg_resultado";
            this.dg_resultado.RowTemplate.Height = 100;
            this.dg_resultado.Size = new System.Drawing.Size(844, 294);
            this.dg_resultado.TabIndex = 1;
            this.dg_resultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_resultado_CellContentClick);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(224, 226);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 13;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // col_apellido
            // 
            this.col_apellido.HeaderText = "Apellido";
            this.col_apellido.Name = "col_apellido";
            // 
            // col_nombre
            // 
            this.col_nombre.HeaderText = "Nombre";
            this.col_nombre.Name = "col_nombre";
            // 
            // col_fechaNacimiento
            // 
            this.col_fechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.col_fechaNacimiento.Name = "col_fechaNacimiento";
            // 
            // col_sexo
            // 
            this.col_sexo.HeaderText = "Sexo";
            this.col_sexo.Name = "col_sexo";
            // 
            // col_eliminar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_eliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_eliminar.HeaderText = "Eliminar";
            this.col_eliminar.Name = "col_eliminar";
            this.col_eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_saldo
            // 
            this.col_saldo.HeaderText = "Saldo";
            this.col_saldo.Name = "col_saldo";
            // 
            // col_foto
            // 
            this.col_foto.HeaderText = "Foto";
            this.col_foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.col_foto.Name = "col_foto";
            this.col_foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_ruta
            // 
            this.col_ruta.HeaderText = "Ruta";
            this.col_ruta.Name = "col_ruta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::WindowsFormsApp1.Properties.Resources.errorImage;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.silueta;
            this.pictureBox1.InitialImage = global::WindowsFormsApp1.Properties.Resources.silueta;
            this.pictureBox1.Location = new System.Drawing.Point(644, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form_tp5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dg_resultado);
            this.Controls.Add(this.panel1);
            this.Name = "Form_tp5";
            this.Text = "Tp5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_resultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_FotoPath;
        private System.Windows.Forms.TextBox tb_Saldo;
        private System.Windows.Forms.TextBox tb_Apellido;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.Label lb_Saldo;
        private System.Windows.Forms.Label lb_Sexo;
        private System.Windows.Forms.Label lb_FechaNacimiento;
        private System.Windows.Forms.Label lb_Apellido;
        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.Button btn_Foto;
        private System.Windows.Forms.RadioButton rb_sexoMujer;
        private System.Windows.Forms.RadioButton rb_sexoHombre;
        private System.Windows.Forms.DateTimePicker dp_FechaNacimiento;
        private System.Windows.Forms.DataGridView dg_resultado;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sexo;
        private System.Windows.Forms.DataGridViewButtonColumn col_eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_saldo;
        private System.Windows.Forms.DataGridViewImageColumn col_foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ruta;
    }
}