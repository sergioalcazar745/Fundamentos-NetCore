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
    public partial class Form12Metodos : Form
    {
        public Form12Metodos()
        {
            InitializeComponent();
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            this.GetDoble(num);
            this.lblResultado.Text = num.ToString();
        }

        void GetDoble(int numero)
        {
            numero = numero * 2;
        }

        private void btnReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            //this.GetDobleReferencia(ref num);
            int resultado = this.GetDobleNumero(num);
            this.lblResultado.Text = resultado.ToString();
        }

        int GetDobleNumero(int numero)
        {
            return numero * 2;
        }

        void GetDobleReferencia(ref int numero)
        {
            numero = numero * 2;
        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnReferencia);
            this.CambiarColor(this.btnValor);
        }

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.Aqua;
        }

        private void lblMouse_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMouse.Text = "X: " + e.X + "Y: " + e.Y;
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char) Keys.Back;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char) Keys.Back;
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}
