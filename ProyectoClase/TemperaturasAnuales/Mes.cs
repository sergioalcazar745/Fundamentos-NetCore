using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase.TemperaturasAnuales
{
    public class Mes
    {
        public Mes() { }
        public Mes(string nombreMes, int maxima, int minima)
        {
            this.TemperaturaMaxima = maxima;
            this.TemperaturaMinima = minima;
            this.NombreMes = nombreMes;
        }
        #region PROPIEDADES
        public string NombreMes { get; set; }
        public int TemperaturaMaxima { get; set; }
        public int TemperaturaMinima { get; set; }
        #endregion

        #region
        public int MediaMensual()
        {
            return (this.TemperaturaMaxima + this.TemperaturaMinima) / 2;
        }
        #endregion
    }
}
