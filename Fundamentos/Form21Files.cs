using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClase.Helpers;

namespace Fundamentos
{
    public partial class Form21Files : Form
    {
        public Form21Files()
        {
            InitializeComponent();
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                string contenido = await HelperFiles.ReadFileAsync(path);
                this.txtContenido.Text = contenido;
                this.SetStringNombres(contenido);
            }
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if(save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;
                string contenido = this.GetStringNombres();
                await HelperFiles.WriteFileAsync(path, contenido);
                MessageBox.Show("Datos guardados");
            }
        }

        public string GetStringNombres()
        {
            string datos = "";
            foreach (string nombre in this.lstNombres.Items)
            {
                datos += nombre + ",";
            }
            datos = datos.Trim(',');
            return datos;
        }

        public void SetStringNombres(string data)
        {
            string[] nombres = data.Split(',');
            this.lstNombres.Items.Clear();
            foreach(string nombre in nombres)
            {
                this.lstNombres.Items.Add(nombre);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            this.lstNombres.Items.Add(nombre);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }
    }
}
