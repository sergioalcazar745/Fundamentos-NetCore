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
    public partial class Form09ColeccionMultiple : Form
    {
        public Form09ColeccionMultiple()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elemento);
            this.txtNuevoElemento.Focus();
            this.txtNuevoElemento.SelectAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int seleccionados = this.lstElementos.SelectedIndices.Count;
            for (int i = seleccionados - 1; i >= 0; i--)
            {
                int index = this.lstElementos.SelectedIndices[i];
                this.lstElementos.Items.RemoveAt(index);
            }
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            foreach (int indice in this.lstElementos.SelectedIndices)
            {
                indices += indice + ",";
            }
            this.lblIndice.Text = indices.Trim(',');

            string items = "";
            foreach(string elemento in this.lstElementos.SelectedItems)
            {
                items += elemento + ",";
            }
            this.lblItem.Text = items.Trim(',');
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            lstElementos.Items.Clear();
        }
    }
}
