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
    public partial class Form17TemperaturasAnuales : Form
    {
        List<string> listaMeses;
        public Form17TemperaturasAnuales()
        {
            InitializeComponent();
            this.GenerarMeses();
        }

        private void btnGenerarMeses_Click(object sender, EventArgs e)
        {
            this.GenerarMeses();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int temperaturaMaxima = 0, temperaturaMinima = 0, mediaAnual = 0;

            foreach (string mes in this.listaMeses)
            {

                int numero = int.Parse(mes.Substring(mes.IndexOf(":") + 1));

                if(numero > temperaturaMaxima)
                {
                    temperaturaMaxima = numero;
                }

                if(numero < temperaturaMinima)
                {
                    temperaturaMinima = numero;
                }
                mediaAnual += numero;
            }

            mediaAnual = mediaAnual / this.listaMeses.Count;
            this.txtMaxima.Text = temperaturaMaxima.ToString();
            this.txtMinimo.Text = temperaturaMinima.ToString();
            this.txtMediaAnual.Text = mediaAnual.ToString();
        }

        // --------------------------- Métodos -----------------------------

        private void GenerarMeses()
        {
            this.lstMeses.Items.Clear();
            this.listaMeses = new List<string>();
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            Random random = new Random();
            
            for (int i = 0; i < meses.Length; i++)
            {
                string mes = meses[i] + ":" + random.Next(-10, 40).ToString();
                this.listaMeses.Add(mes);
                this.lstMeses.Items.Add(mes);
            }
        }
    }
}
