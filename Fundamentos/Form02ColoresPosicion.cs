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
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnCambiarPosicion_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.txtX.Text);
            int y = int.Parse(this.txtY.Text);

            this.btnCambiarPosicion.Location = new Point(x, y);
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {

            int rojo = 0;
            int azul = 0;
            int verde = 0;

            try
            {
                rojo = int.Parse(this.txtRojo.Text);
                azul = int.Parse(this.txtAzul.Text);
                verde = int.Parse(this.txtVerde.Text);

                if (rojo <= 0 || rojo > 255)
                {
                    MessageBox.Show("El color rojo debe estar entre 0 y 255");
                }
                else if (azul <= 0 || azul > 255)
                {
                    MessageBox.Show("El color rojo debe estar entre 0 y 255");
                }
                else if (verde <= 0 || verde > 255)
                {
                    MessageBox.Show("El color rojo debe estar entre 0 y 255");
                }

                this.BackColor = Color.FromArgb(rojo, verde, azul);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Por favor introduce numero en las cajas.");
            }

            
        }
    }
}
