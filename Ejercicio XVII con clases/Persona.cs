using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_XVII_con_clases
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected string _nombreCompleto;
        protected DateTime _fechaNacimiento;



        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public string NombreCompleto
        {
            get { return (this._nombre + " " + this._apellido) ; }
            set { this._nombreCompleto = this._nombre + " " + this._apellido; }
        } 

        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
    }
}
