using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase.TemperaturasAnuales
{
    public class Año
    {
        public Año() {}
        public Año(int anio, List<Mes> meses)
        {
            this.anio = anio;
            this.meses = meses;
        }
        #region PROPIEDADES
        public int anio { get; set; }
        public List<Mes> meses { get; set; }
        #endregion

        #region METODOS
        public int MinimaAnual()
        {
            return this.meses.Max(r => r.TemperaturaMinima);
        }

        public int MaximaAnual()
        {
            return this.meses.Max(r => r.TemperaturaMaxima);
        }

        public int MediaAnual()
        {
            return (int)this.meses.Average(item => item.MediaMensual());
        }
        #endregion
    }
}
