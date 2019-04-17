using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            int a, b, suma;
            Console.WriteLine("Ingrese 2 numeros: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            suma = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, suma);
            Alumno alumno = new Alumno();
            alumno.Codigo = 201521543;
            alumno.Nombre = "Andre";
            alumno.Apellido = "Gonzales Soncco";
            alumno.Carrera = "Ing. de Software";
            Console.WriteLine("Alumno: {0} {1} estudia {2}",alumno.Nombre,alumno.Apellido,alumno.Carrera);
            Console.ReadKey();
        }
    }
}
