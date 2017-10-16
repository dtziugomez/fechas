using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace fechas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mcFechaViaje_DateSelected(object sender, DateRangeEventArgs e)
        {
            StringBuilder sbMensajes = new StringBuilder();
            sbMensajes.Append(this.lblInicio.Text + "\n");
            sbMensajes.Append(e.Start.ToShortDateString());
            this.lblInicio.Text = sbMensajes.ToString();
            sbMensajes.Remove(0, sbMensajes.Length);
            sbMensajes.Append(this.lblFin.Text + "\n");
            sbMensajes.Append(e.End.ToShortDateString());
            this.lblFin.Text= sbMensajes.ToString();

        }

        private void rbFormatoLargo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFormatoCorto.Checked)
                dtpLanzamiento.Format = DateTimePickerFormat.Long;

        }

        private void rbFormatoCorto_CheckedChanged(object sender, EventArgs e)
        {

            if (rbFormatoCorto.Checked)
                dtpLanzamiento.Format = DateTimePickerFormat.Short;
        }
    }
}