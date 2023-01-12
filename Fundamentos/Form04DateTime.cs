using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            this.txtFechaActual.Text = DateTime.Now.ToString();
        }

        private void cbCambiarFormatoFecha_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);

            if (this.cbCambiarFormatoFecha.Checked)
            {
                this.txtFechaActual.Text = fecha.ToString();
            }
            else
            {
                this.txtFechaActual.Text = fecha.ToLongDateString();
            }
        }

        private void btnIncremento_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(txtIncrementar.Text);
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);

            if (this.rdbDias.Checked)
            {
                fecha = fecha.AddDays(incremento);
            }
            else if (this.rdbMeses.Checked)
            {
                fecha = fecha.AddMonths(incremento);
            }
            else if (this.rdbAños.Checked)
            {
                fecha = fecha.AddYears(incremento);
            }
            else
            {
                MessageBox.Show("Debes seleccionar alguna opcion de incremento.");
            }

            this.txtNuevaFecha.Text = fecha.ToString();
        }
    }
}
