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
    public partial class Form07SumarNumeros : Form
    {
        public Form07SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumarNumeros_Click(object sender, EventArgs e)
        {
            string numeros = this.txtNumeros.Text;
            int resultado = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                char caracter = numeros[i];
                resultado += int.Parse(caracter.ToString());
            }

            lblResultado.Text = "El resultado es: " + resultado;
        }
    }
}
