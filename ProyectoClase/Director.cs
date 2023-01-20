using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase
{
    public class Director: Empleado
    {
        public Director()
        {
            this.SalarioMinimo += 200;
        }
        public override int GetDiasVacaciones()
        {
            Debug.WriteLine("GetDiasVacaciones() DIRECTOR");
            return 30;
        }

        public override string ToString()
        {
            return "Nombre: " + this.Nombre + "Vacaciones: " + this.GetDiasVacaciones();
        }
    }
}
