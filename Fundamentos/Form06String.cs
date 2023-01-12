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
    public partial class Form06String : Form
    {
        public Form06String()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (email.IndexOf("@") == -1)
            {
                lblResultado.Text = "Tiene que contener una @.";
            }
            else if (email.StartsWith("@") || email.EndsWith("@"))
            {
                lblResultado.Text = "Tiene que contener una @.";
            }
            else if (email.IndexOf('@') != -1 && email.IndexOf("@", email.IndexOf('@') + 1) != -1)
            {
                lblResultado.Text = "Tiene mas de una @.";
            }
            else if (email.IndexOf(".") == -1)
            {
                lblResultado.Text = "No existe un punto.";
            }
            else if (email.IndexOf(".", email.IndexOf("@")) == -1)
            {
                lblResultado.Text = "No existe un punto depues de la @.";
            }
            else if (email.Substring(email.LastIndexOf(".") + 1).Length < 2 || email.Substring(email.LastIndexOf(".") + 1).Length > 4)
            {
                lblResultado.Text = "El dominio debe tener entre 2 y 4 caracteres.";
            }
            else
            {
                lblResultado.Text = "Email correcto";
            }
        }
    }
}
