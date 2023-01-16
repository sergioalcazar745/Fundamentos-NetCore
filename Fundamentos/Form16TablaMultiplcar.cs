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
    public partial class Form16TablaMultiplcar : Form
    {
        List<TextBox> cajas;
        public Form16TablaMultiplcar()
        {
            InitializeComponent();
            this.cajas = new List<TextBox>();
            Random random = new Random();
            foreach (TextBox caja in this.grpbTablaMultiplicar.Controls)
            {
                this.cajas.Add(caja);
            }
            this.cajas.Reverse();
        }

        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            for (int i = 0; i < this.cajas.Count; i++)
            {
                this.cajas[i].Text = (numero * (i + 1)).ToString();
            }
        }
    }
}
