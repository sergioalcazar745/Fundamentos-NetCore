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
    public partial class Form15SumarBotones : Form
    {
        List<Button> botones;
        int suma;
        public Form15SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.suma = 0;
            Random random = new Random();

            foreach(Control control in this.panelBotones.Controls)
            {
                if(control is Button)
                {
                    this.botones.Add((Button)control);
                }
            }

            foreach (Button boton in this.botones)
            {
                boton.Text = random.Next(1, 200).ToString();
                boton.Click += BotonPulsado;
            }
        }

        private void BotonPulsado(object? sender, EventArgs e)
        {
            Button boton = (Button)sender;
            suma += int.Parse(boton.Text);
            boton.BackColor = Color.Aqua;
            this.textBox1.Text = suma.ToString();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.textBox1.Text = "0";
            foreach (Button boton in this.botones)
            {
                boton.Text = random.Next(1, 200).ToString();
                boton.Click += BotonPulsado;
                boton.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
            }
        }
    }
}
