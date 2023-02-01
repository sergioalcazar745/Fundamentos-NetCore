using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form11TiendaProductos : Form
    {
        public Form11TiendaProductos()
        {
            Stopwatch krono;

            InitializeComponent();
            this.txtProducto.Focus();
            this.btnSubir.Enabled = false;
            this.btnBajar.Enabled = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.InsertarProducto();
        }

        void InsertarProducto()
        {
            string producto = txtProducto.Text;
            if (!string.IsNullOrEmpty(producto))
            {
                this.lstTienda.Items.Add(producto);
                this.txtProducto.Clear();
            }
            else
            {
                MessageBox.Show("La caja de producto esta vacía");
            }
            this.txtProducto.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(this.lstTienda.SelectedIndices.Count > 0)
            {
                int seleccionados = this.lstTienda.SelectedIndices.Count;
                for (int i = seleccionados - 1; i >= 0; i--)
                {
                    int index = this.lstTienda.SelectedIndices[i];
                    this.lstTienda.Items.RemoveAt(index);
                }
            }
            else
            {
                MessageBox.Show("No hay ningun producto seleccionado");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.lstTienda.SelectedIndices.Count > 0)
            {
                int seleccionado = this.lstTienda.SelectedIndices[0];
                if (!string.IsNullOrEmpty(txtProducto.Text))
                {
                    this.lstTienda.Items[seleccionado] = this.txtProducto.Text;
                    this.txtProducto.Clear();
                }
                else
                {
                    MessageBox.Show("La caja producto está vacía");
                }
            }
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            if (this.lstTienda.SelectedIndices.Count > 0)
            {
                int seleccionados = this.lstTienda.SelectedIndices.Count;
                for (int i = 0; i < seleccionados; i++)
                {
                    int index = this.lstTienda.SelectedIndices[i];
                    string item = this.lstTienda.Items[index].ToString();
                    this.lstAlmacen.Items.Add(item);
                }

                for (int i = seleccionados - 1; i >= 0; i--)
                {
                    int index = this.lstTienda.SelectedIndices[i];
                    this.lstTienda.Items.RemoveAt(index);
                }
                lstAlmacen.SelectedIndex = 0;
                this.btnBajar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No hay ningun producto seleccionado");
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            if(lstTienda.Items.Count > 0)
            {
                foreach (string item in this.lstTienda.Items)
                {
                    lstAlmacen.Items.Add(item);
                }
                lstAlmacen.SelectedIndex = 0;
                this.btnBajar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No hay ningun producto en la tienda");
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (this.lstAlmacen.Items.Count > 1)
            {
                this.btnBajar.Enabled = true;
                int seleccionado = lstAlmacen.SelectedIndex;
                string seleccionadoTexto = lstAlmacen.SelectedItem.ToString();
                if (seleccionado - 1 >= 0)
                {
                    this.lstAlmacen.Items.RemoveAt(seleccionado);
                    this.lstAlmacen.Items.Insert(seleccionado - 1, seleccionadoTexto);

                    if (seleccionado -1 == 0)
                    {
                        this.btnBajar.Enabled = true;
                        this.btnSubir.Enabled = false;
                    }
                    this.lstAlmacen.SelectedIndex = seleccionado - 1;
                }
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            if(this.lstAlmacen.Items.Count > 1)
            {
                this.btnSubir.Enabled = true;
                int seleccionado = lstAlmacen.SelectedIndex;
                string seleccionadoTexto = lstAlmacen.SelectedItem.ToString();
                if(seleccionado + 1 <= lstAlmacen.Items.Count - 1)
                {
                    this.lstAlmacen.Items.RemoveAt(seleccionado);
                    this.lstAlmacen.Items.Insert(seleccionado + 1, seleccionadoTexto);

                    if (seleccionado + 1 == lstAlmacen.Items.Count - 1)
                    {
                        this.btnBajar.Enabled = false;
                        this.btnSubir.Enabled = true;
                    }
                    this.lstAlmacen.SelectedIndex = seleccionado + 1;
                }
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaPulsada = (char)Keys.Enter;
            if(e.KeyChar == teclaPulsada)
            {
                this.InsertarProducto();
            }
        }
    }
}
