using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase
{
    public class Empleado: Persona
    {
        public Empleado()
        {
            Debug.WriteLine("Constructor EMPLEADO vacio");
            this.SalarioMinimo = 1000;
        }

        public Empleado(string nombre, string apellidos)
            :base(nombre, apellidos)
        {
            Debug.WriteLine("Constructor EMPLEADO dos parametros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        #region PROPIEDADES
        protected int SalarioMinimo { get; set; }
        #endregion
    }
}
