namespace fechas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.mcFechaViaje = new System.Windows.Forms.MonthCalendar();
            this.dtpLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rbFormatoLargo = new System.Windows.Forms.RadioButton();
            this.rbFormatoCorto = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "selecciona los dias de tu viaje";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(262, 57);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(76, 13);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "fecha de inicio";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(262, 119);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(63, 13);
            this.lblFin.TabIndex = 2;
            this.lblFin.Text = "fecha de fin";
            // 
            // mcFechaViaje
            // 
            this.mcFechaViaje.Location = new System.Drawing.Point(43, 40);
            this.mcFechaViaje.Name = "mcFechaViaje";
            this.mcFechaViaje.TabIndex = 3;
            this.mcFechaViaje.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcFechaViaje_DateSelected);
            // 
            // dtpLanzamiento
            // 
            this.dtpLanzamiento.Location = new System.Drawing.Point(30, 224);
            this.dtpLanzamiento.Name = "dtpLanzamiento";
            this.dtpLanzamiento.Size = new System.Drawing.Size(200, 20);
            this.dtpLanzamiento.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "fecha del lanzamiento del producto";
            // 
            // rbFormatoLargo
            // 
            this.rbFormatoLargo.AutoSize = true;
            this.rbFormatoLargo.Location = new System.Drawing.Point(53, 290);
            this.rbFormatoLargo.Name = "rbFormatoLargo";
            this.rbFormatoLargo.Size = new System.Drawing.Size(131, 17);
            this.rbFormatoLargo.TabIndex = 6;
            this.rbFormatoLargo.TabStop = true;
            this.rbFormatoLargo.Text = "formato de fecha largo";
            this.rbFormatoLargo.UseVisualStyleBackColor = true;
            this.rbFormatoLargo.CheckedChanged += new System.EventHandler(this.rbFormatoLargo_CheckedChanged);
            // 
            // rbFormatoCorto
            // 
            this.rbFormatoCorto.AutoSize = true;
            this.rbFormatoCorto.Location = new System.Drawing.Point(201, 290);
            this.rbFormatoCorto.Name = "rbFormatoCorto";
            this.rbFormatoCorto.Size = new System.Drawing.Size(132, 17);
            this.rbFormatoCorto.TabIndex = 7;
            this.rbFormatoCorto.TabStop = true;
            this.rbFormatoCorto.Text = "formato de fecha corto";
            this.rbFormatoCorto.UseVisualStyleBackColor = true;
            this.rbFormatoCorto.CheckedChanged += new System.EventHandler(this.rbFormatoCorto_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 339);
            this.Controls.Add(this.rbFormatoCorto);
            this.Controls.Add(this.rbFormatoLargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpLanzamiento);
            this.Controls.Add(this.mcFechaViaje);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.MonthCalendar mcFechaViaje;
        private System.Windows.Forms.DateTimePicker dtpLanzamiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbFormatoLargo;
        private System.Windows.Forms.RadioButton rbFormatoCorto;
    }
}

