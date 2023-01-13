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
    public partial class Form10Random : Form
    {
        public Form10Random()
        {
            InitializeComponent();
            lstRandom.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            lstRandom.Items.Clear();

            for (int i = 0; i < 10; i++)
            {
                lstRandom.Items.Add(random.Next(1, 10));
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int pares = 0;
            int impares = 0;

            foreach (int item in lstRandom.Items)
            {
                if(item % 2 == 0)
                {
                    pares += item;
                }
                else
                {
                    impares += item;
                }
                suma += item;
            }

            txtSuma.Text = "" + suma;
            txtPares.Text = "" + pares;
            txtImpares.Text = "" + impares;
        }

        private void btnSumaSeleccionados_Click(object sender, EventArgs e)
        {
            if(lstRandom.SelectedIndex != -1)
            {
                int suma = 0;
                int pares = 0;
                int impares = 0;

                foreach (object item in lstRandom.SelectedItems)
                {
                    if ((int)item % 2 == 0)
                    {
                        pares += (int)item;
                    }
                    else
                    {
                        impares += (int)item;
                    }
                    suma += (int)item;
                }

                txtSuma.Text = "" + suma;
                txtPares.Text = "" + pares;
                txtImpares.Text = "" + impares;
            }
        }
    }
}
