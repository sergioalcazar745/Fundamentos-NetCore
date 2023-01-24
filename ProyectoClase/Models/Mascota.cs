using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProyectoClase.Models
{
    public class Mascota
    {
        #region PROPIEDADES
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int Years { get; set; }
        public byte[] Imagen { get; set; }

        #endregion
    }
}
