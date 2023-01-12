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
    public partial class Form08ColeccionGrafica : Form
    {
        public Form08ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elemento);
            this.txtNuevoElemento.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(this.lstElementos.SelectedIndex != -1)
            {
                int seleccionado = this.lstElementos.SelectedIndex;
                this.lstElementos.Items.RemoveAt(seleccionado);
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstElementos.SelectedIndex != -1)
            {
                this.lblIndice.Text = this.lstElementos.SelectedIndex.ToString();
                this.lblItem.Text = this.lstElementos.SelectedItem.ToString();
            }
        }
    }
}
