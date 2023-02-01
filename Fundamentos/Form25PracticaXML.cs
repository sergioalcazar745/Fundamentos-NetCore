using ProyectoClase.Helpers;
using ProyectoClase.Models;
using ProyectoClase.Repositories;
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
    public partial class Form25PracticaXML : Form
    {
        RepositoryLink repo;
        public Form25PracticaXML()
        {
            InitializeComponent();
            this.repo = new RepositoryLink();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnLeerDato_Click(object sender, EventArgs e)
        {
            List<Link> lista = this.repo.GetDatos();
            foreach(Link link in lista)
            {
                ListViewItem item = new ListViewItem(link.Titulo);
                item.SubItems.Add(link.Href);
                item.SubItems.Add(link.Edad.ToString());
                item.Tag = link.Imagen;
                this.lstLista.Items.Add(item);
            }
        }

        private void btnGuardarDato_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {

        }

        private async void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = ((ListView)sender).SelectedItems[0];
            string path = item.Tag.ToString();
            byte[] bites = await File.ReadAllBytesAsync(path);
            this.pictureBox1.Image = Image.FromStream(HelperMascotas.ConvertBytesToStream(bites));
        }
    }
}
