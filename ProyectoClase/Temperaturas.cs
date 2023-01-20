using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase
{
    public class Temperaturas
    {
        public Temperaturas(int temperaturaMaxima, int temperaturaMinima)
        {
            this.TemperaturaMaxima = temperaturaMaxima;
            this.TemperaturaMinima = temperaturaMinima;
            this.calcularMediaAnual();
        }

        #region PROPIEDADES
        public int TemperaturaMaxima { get; set; }
        public int TemperaturaMinima { get; set; }
        public int MediaAnual { get; set; }
        #endregion

        #region METODOS
        private void calcularMediaAnual()
        {
            this.MediaAnual = (this.TemperaturaMaxima + this.TemperaturaMinima) / 2;
        }
        #endregion
    }
}
