using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase
{
    #region ENUMS
    public enum TiposGenero { Masculino = 9, Femenino = 10 }
    public enum Paises { España, Italia, Francia, Brasil }
    #endregion

    public class Persona
    {
        public Persona()
        {
            Debug.WriteLine("Constructor PERSONA vacio");
            this.direccionVacaciones = new Direccion("AA", "AAA", 7777);
        }

        public Persona(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor PERSONA dos parametros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        #region CAMPOS PROPIEDADES
        private TiposGenero _Genero;
        private Paises _Nacionalidad;
        private int _Edad;
        #endregion

        #region PROPIEDADES
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public Direccion direccion { get; set; }
        public Direccion direccionVacaciones { get; set; }
        public int Edad
        {
            get { return this._Edad; }
            set
            {
                if (value > 0)
                {
                    this._Edad = value;
                }
                else
                {
                    throw new Exception("La edad no puede ser negativa");
                }
            }
        }
        public TiposGenero Genero
        {
            get { return this._Genero; }
            set {
                if(value != TiposGenero.Masculino && 
                    value != TiposGenero.Femenino)
                {
                    this._Genero = value;
                }
            }
        }

        public Paises Nacionalidad
        {
            get { return this._Nacionalidad; }
            set
            {
                this._Nacionalidad = value;
            }
        }
        #endregion

        #region METODOS

        public string GetNombreCompleto()
        {
            return "Nombre: " + this.Nombre + " Apellidos: " + this.Apellidos; 
        }

        public void GetNombreCompleto(string dato) { }
        public void GetNombreCompleto(int numero) { }
        public void GetNombreCompleto(string nombre, string apellido) { }

        public void MetodoParametrosOpcionales(int numero1, int numero2 = 199, int numero3 = 100)
        {}

        #endregion
    }
}