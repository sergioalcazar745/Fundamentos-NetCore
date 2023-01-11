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
    public partial class Form03CalcularDiaSemana : Form
    {
        public Form03CalcularDiaSemana()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String[] diasSemana = { "Sabado", "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };

            try
            {
                int dia = int.Parse(this.txtDia.Text);
                int mes = int.Parse(this.txtMes.Text);
                int año = int.Parse(this.txtAño.Text);

                if(mes < 1 || mes > 12)
                {
                    throw new ArgumentOutOfRangeException("El mes es incorrecto", new ArgumentOutOfRangeException());
                }

                if(mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dia < 1 || dia > 31)
                    {
                        throw new ArgumentOutOfRangeException("El dia es incorrecto", new ArgumentOutOfRangeException());
                    }

                }
                else if (mes == 2)
                {
                    if (dia < 1 || dia > 28)
                    {
                        throw new ArgumentOutOfRangeException("El dia es incorrecto", new ArgumentOutOfRangeException());
                    }
                }
                else
                {
                    if (dia < 1 || dia > 30)
                    {
                        throw new ArgumentOutOfRangeException("El dia es incorrecto", new ArgumentOutOfRangeException());
                    }
                }

                if(mes == 1)
                {
                    mes = 13;
                    año = año - 1;
                }
                else if (mes == 2)
                {
                    mes = 14;
                    año = año - 1;
                }

                int resultado1 = ((mes + 1) * 3) / 5;
                int resultado2 = año / 4;
                int resultado3 = año / 100;
                int resultado4 = año / 400;
                int resultado5 = dia + (mes * 2) + año + resultado1 + resultado2 - resultado3 + resultado4 + 2;
                int resultado6 = resultado5 / 7;
                int resultado7 = resultado5 - (resultado6 * 7);
                this.lblResultado.Text = diasSemana[resultado7];

            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los valores deben ser numero enteros");
            }
        }
    }
}
