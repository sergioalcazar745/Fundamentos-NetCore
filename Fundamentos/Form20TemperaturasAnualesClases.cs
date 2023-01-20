using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClase.TemperaturasAnuales;
using System.Diagnostics;

namespace Fundamentos
{
    public partial class Form20TemperaturasAnualesClases : Form
    {
        List<Año> años;
        Año anio;
        public Form20TemperaturasAnualesClases()
        {
            InitializeComponent();
            this.años = new List<Año>();
        }

        private void btnGenerarMeses_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            DateTime tiempo = DateTime.Parse("01/01/2023");

            for (int i = 0; i < this.cbAños.Items.Count; i++)
            {
                List<Mes> meses = new List<Mes>();

                for (int j = 1; j <= 12; j++)
                {
                    string nombreMes = tiempo.ToString("MMMM").ToUpper();
                    Mes mes = new Mes(nombreMes, random.Next(15, 40), random.Next(-10, 14));
                    meses.Add(mes);
                    tiempo = tiempo.AddMonths(1);
                }
                Año año = new Año(int.Parse(this.cbAños.Items[i].ToString()), meses);
                años.Add(año);
            }
            MessageBox.Show("Meses Generados"); 
        }

        private void cbAños_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.limpiarCamposAnual();
            this.limpiarCamposMes();
            if(this.años.Count > 0)
            {
                this.anio = this.años[this.cbAños.SelectedIndex];
                this.MostrarMeses();
                this.txtMaximaAnual.Text = anio.MaximaAnual().ToString();
                this.txtMinimaAnual.Text = anio.MinimaAnual().ToString();
                this.txtMediaAnual.Text = anio.MediaAnual().ToString();
            }
            else
            {
                MessageBox.Show("No existen meses");
            }
        }

        private void lstMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstMeses.SelectedIndex != -1)
            {
                Mes mes = this.anio.meses[this.lstMeses.SelectedIndex];
                this.txtMaximaMensual.Text = mes.TemperaturaMaxima.ToString();
                this.txtMinimoMensual.Text = mes.TemperaturaMinima.ToString();
                this.txtMediaMensual.Text = mes.MediaMensual().ToString();
            }
        }

        private void MostrarMeses()
        {
            this.lstMeses.Items.Clear();
            foreach (Mes mes in this.anio.meses)
            {
                this.lstMeses.Items.Add(mes.NombreMes);
            }
        }

        private void limpiarCamposMes()
        {
            this.txtMaximaMensual.Clear();
            this.txtMinimoMensual.Clear();
            this.txtMediaMensual.Clear();
        }

        private void limpiarCamposAnual()
        {
            this.txtMaximaAnual.Clear();
            this.txtMinimaAnual.Clear();
            this.txtMinimaAnual.Clear();
        }
    }
}
