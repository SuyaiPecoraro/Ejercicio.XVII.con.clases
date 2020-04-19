using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Para compilar: ctrol + shift + b
// Para recordar: Si en una clase padre el constructor tiene parametros, en la hija (en el contructor) hay que poner : base (parametros)
namespace Ejercicio_XVII_con_clases
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 3; i++)
            {
                      //  Empleado e = new Empleado(); 
                      Console.WriteLine("Por favor, ingrese el nombre.");
                      string n = Console.ReadLine();
                      //emp.Add(new Empleado() { Nombre = Console.ReadLine() });
                      Console.WriteLine("Por favor, ingrese el apellido.");
                      string a = Console.ReadLine();
                      //emp.Add(new Empleado() { Apellido = Console.ReadLine() });
                      Console.WriteLine("Por favor, ingrese el sueldo.");
                      double s = double.Parse(Console.ReadLine());
                      //emp.Add(new Empleado() { Sueldo = double.Parse(Console.ReadLine()) });
                     

                Empleado e1 = new Empleado(n, a, s);

                e1 = e1.CargarLista(); 
                 
            }

           /* string n = "asd";
            string a = "dsa";
            double s = 5;

            Empleado e1 = new Empleado(n, a, s);

            e1 = e1.CargarLista(); //(n, a, s);*/
            Empleado e2 = new Empleado();
            e2.CargarLista();
            
            Console.WriteLine("El mayor sueldo corresponde a " + e2.NombreCompleto + " y es de $ " + e2.Sueldo);
            Console.ReadLine();
        }
    }
}
