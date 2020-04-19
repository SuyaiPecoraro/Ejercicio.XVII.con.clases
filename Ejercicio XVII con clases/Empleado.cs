using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_XVII_con_clases
{
    class Empleado : Persona
    {
        private double _sueldo;

        private List<Empleado> Empleados = new List<Empleado>();

        public Empleado()
        {

        }

        public Empleado(string nombre, string apellido, double sueldo)
        {
            this.Nombre = nombre;
            this.Apellido =  apellido;
            this._sueldo = sueldo;
            this.Empleados.Add(this);
        }
     
        public double Sueldo { get => this._sueldo; set => this._sueldo = value; }

        public Empleado CargarLista() //string nombre, string apellido, double sueldo)
        {
            //Empleados.Add(new Empleado(nombre, apellido, sueldo));

            Empleados.OrderByDescending(x => x.Sueldo);

            return Empleados[0];
        }
         
    }
}
