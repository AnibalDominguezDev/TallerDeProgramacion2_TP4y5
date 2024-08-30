namespace WindowsFormsApp1
{
    partial class Form_tp4
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lb_Dede = new System.Windows.Forms.Label();
            this.lb_Hasta = new System.Windows.Forms.Label();
            this.tb_Desde = new System.Windows.Forms.TextBox();
            this.tb_Hasta = new System.Windows.Forms.TextBox();
            this.btn_GenerarFuncion = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btn_Pares = new System.Windows.Forms.Button();
            this.btn_Impares = new System.Windows.Forms.Button();
            this.btn_Primos = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Dede
            // 
            this.lb_Dede.AutoSize = true;
            this.lb_Dede.Location = new System.Drawing.Point(32, 50);
            this.lb_Dede.Name = "lb_Dede";
            this.lb_Dede.Size = new System.Drawing.Size(41, 13);
            this.lb_Dede.TabIndex = 0;
            this.lb_Dede.Text = "Desde:";
            // 
            // lb_Hasta
            // 
            this.lb_Hasta.AutoSize = true;
            this.lb_Hasta.Location = new System.Drawing.Point(32, 83);
            this.lb_Hasta.Name = "lb_Hasta";
            this.lb_Hasta.Size = new System.Drawing.Size(38, 13);
            this.lb_Hasta.TabIndex = 1;
            this.lb_Hasta.Text = "Hasta:";
            // 
            // tb_Desde
            // 
            this.tb_Desde.Location = new System.Drawing.Point(76, 47);
            this.tb_Desde.Name = "tb_Desde";
            this.tb_Desde.Size = new System.Drawing.Size(100, 20);
            this.tb_Desde.TabIndex = 2;
            this.tb_Desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Desde_KeyPress);
            // 
            // tb_Hasta
            // 
            this.tb_Hasta.Location = new System.Drawing.Point(76, 80);
            this.tb_Hasta.Name = "tb_Hasta";
            this.tb_Hasta.Size = new System.Drawing.Size(100, 20);
            this.tb_Hasta.TabIndex = 3;
            this.tb_Hasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Hasta_KeyPress);
            // 
            // btn_GenerarFuncion
            // 
            this.btn_GenerarFuncion.Location = new System.Drawing.Point(32, 140);
            this.btn_GenerarFuncion.Name = "btn_GenerarFuncion";
            this.btn_GenerarFuncion.Size = new System.Drawing.Size(124, 23);
            this.btn_GenerarFuncion.TabIndex = 4;
            this.btn_GenerarFuncion.Text = "Generar funcion";
            this.btn_GenerarFuncion.UseVisualStyleBackColor = true;
            this.btn_GenerarFuncion.Click += new System.EventHandler(this.btn_GenerarFuncion_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(220, 47);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(257, 212);
            this.listBox.TabIndex = 5;
            // 
            // btn_Pares
            // 
            this.btn_Pares.Location = new System.Drawing.Point(32, 180);
            this.btn_Pares.Name = "btn_Pares";
            this.btn_Pares.Size = new System.Drawing.Size(124, 23);
            this.btn_Pares.TabIndex = 6;
            this.btn_Pares.Text = "Numeros pares";
            this.btn_Pares.UseVisualStyleBackColor = true;
            this.btn_Pares.Click += new System.EventHandler(this.btn_Pares_Click);
            // 
            // btn_Impares
            // 
            this.btn_Impares.Location = new System.Drawing.Point(32, 220);
            this.btn_Impares.Name = "btn_Impares";
            this.btn_Impares.Size = new System.Drawing.Size(124, 23);
            this.btn_Impares.TabIndex = 7;
            this.btn_Impares.Text = "Numeros Impares";
            this.btn_Impares.UseVisualStyleBackColor = true;
            this.btn_Impares.Click += new System.EventHandler(this.btn_Impares_Click);
            // 
            // btn_Primos
            // 
            this.btn_Primos.Location = new System.Drawing.Point(32, 258);
            this.btn_Primos.Name = "btn_Primos";
            this.btn_Primos.Size = new System.Drawing.Size(124, 23);
            this.btn_Primos.TabIndex = 8;
            this.btn_Primos.Text = "Numeros Primos";
            this.btn_Primos.UseVisualStyleBackColor = true;
            this.btn_Primos.Click += new System.EventHandler(this.btn_Primos_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(498, 47);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(267, 212);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_tp4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_Primos);
            this.Controls.Add(this.btn_Impares);
            this.Controls.Add(this.btn_Pares);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btn_GenerarFuncion);
            this.Controls.Add(this.tb_Hasta);
            this.Controls.Add(this.tb_Desde);
            this.Controls.Add(this.lb_Hasta);
            this.Controls.Add(this.lb_Dede);
            this.Name = "Form_tp4";
            this.Text = "Tp4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Dede;
        private System.Windows.Forms.Label lb_Hasta;
        private System.Windows.Forms.TextBox tb_Desde;
        private System.Windows.Forms.TextBox tb_Hasta;
        private System.Windows.Forms.Button btn_GenerarFuncion;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btn_Pares;
        private System.Windows.Forms.Button btn_Impares;
        private System.Windows.Forms.Button btn_Primos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

