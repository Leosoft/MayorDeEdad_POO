using System;

namespace MayorDeEdad_POO
{
    class Program
    {
        static void Main(string[] args)
        {


            Persona per = new Persona();
            int edadactual = 0;


            Console.WriteLine("Ingrese su edad: ");
            edadactual = Convert.ToInt16(Console.ReadLine());
            bool condi = per.ComprobarEdad(edadactual);
            Console.WriteLine("Nombre: {0}", per.nombre);
            Console.WriteLine("Edad: " + per.edad);

            if (condi == true)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }

            Console.ReadKey();
        }
    }
}
