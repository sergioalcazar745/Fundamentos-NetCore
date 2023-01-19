using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClase;

namespace Fundamentos
{
    public partial class Form19TemperaturasClases : Form
    {
        List<Temperaturas> temperaturas;
        public Form19TemperaturasClases()
        {
            InitializeComponent();
            this.temperaturas = new List<Temperaturas>();
        }

        private void btnGenerarMeses_Click(object sender, EventArgs e)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            foreach(string mes in meses)
            {
                this.lstMeses.Items.Add(mes);
                
            }
        }

        private void lstMeses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
