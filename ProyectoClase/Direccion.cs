using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProyectoClase
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public  int CodigoPostal { get; set; }

        public Direccion()
        {
            Debug.WriteLine("Constructor Direccion sin parámetros");
        }

        public Direccion(string calle, string ciudad)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor Direccion DOS parámetros");
        }

        public Direccion(string calle, string ciudad, int codigoPostal)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = codigoPostal;
            Debug.WriteLine("Constructor Direccion TRES parámetros");
        }
    }
}
