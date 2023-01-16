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
    public partial class Form14ListEventos : Form
    {
        List<Button> botones;
        int contador;
        public Form14ListEventos()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.contador = 0;

            foreach (Control control in this.Controls)
            {
                if(control is Button)
                {
                    this.botones.Add((Button) control);
                    ((Button)control).BackColor = Color.Aqua;
                }
            }

            foreach (Button boton in botones)
            {
                boton.Click += botonPulsado;
            }
        }

        private void botonPulsado(object? sender, EventArgs e)
        {
            this.contador += 1;
            this.txtCaja.Text = "Contador: " + this.contador;
            Button boton = (Button)sender;
            boton.BackColor = Color.LightCoral;
            boton.Text = this.contador.ToString();
        }
    }
}
