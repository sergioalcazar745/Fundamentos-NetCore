﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClase;

namespace Fundamentos
{
    public partial class Form18PruebaClases : Form
    {
        public Form18PruebaClases()
        {
            InitializeComponent();
        }

        private void btnVerPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            //persona.Nombre = "Alumno";
            this.lstDatos.Items.Add("Nombre: " + persona.Nombre);
            this.lstDatos.Items.Add("Nombre: " + persona.direccion.Calle);
            persona.Apellidos = "Net Core";
            persona.Edad = 20;
            //persona.Nacionalidad = Paises.España;
            //persona.Genero = TipoGenero.Masculino;
            persona.MetodoParametrosOpcionales(1, 2, 3);
            persona.MetodoParametrosOpcionales(1, numero3: 20);

            //this.lstDatos.Items.Add(persona.Nombre + " " + persona.Apellidos + ", Edad: " + persona.Edad + ", " + 
            //    persona.Nacionalidad + " Género: " + persona.Genero);
        }
    }
}
