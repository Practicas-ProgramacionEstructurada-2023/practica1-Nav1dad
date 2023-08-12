using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            // Declaracion de variables
           string? nombre;
           int? edad;
           string? direccion;
           int? telefono;
           string? universidad;
           string? carrera;
           string? facultad;
           int? ciclo;

           Console.WriteLine("\npractica 1 - programacion estructurada\n");
           Console.WriteLine("ingrese su nombre completo:");// Obtener datos
           nombre = Convert.ToString(Console.ReadLine());
           Console.WriteLine("\n");

           Console.WriteLine("ingrese su edad:");// Obtener datos
           edad = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("\n");

           Console.WriteLine("ingrese tu direccion:");// Obtener datos
           direccion = Convert.ToString(Console.ReadLine());
           Console.WriteLine("\n");

           Console.WriteLine("ingresa tu telefono:");// Obtener datos
           telefono = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("\n");

           Console.WriteLine("universidad:");// Obtener datos
           universidad = Convert.ToString(Console.ReadLine());
           Console.WriteLine("\n");

           Console.WriteLine("carrera:");// Obtener datos
           carrera = Convert.ToString(Console.ReadLine());
           Console.WriteLine("\n");

           Console.WriteLine("facultad:");// Obtener datos
           facultad = Convert.ToString(Console.ReadLine());
           Console.WriteLine("\n");

           Console.WriteLine("ciclo:"); // Obtener datos
           ciclo = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("\n");

           // Imprimiendo datos
           Console.WriteLine("su nombre es :" + nombre);
           Console.WriteLine("su edad :" + edad);
           Console.WriteLine("su direccion es :" + direccion);
           Console.WriteLine("su telefono es  :" + telefono);
           Console.WriteLine("su universidad es :" + universidad);
           Console.WriteLine("su carrera es :" + carrera);
           Console.WriteLine("Facultad que pertenece :" + facultad);
           Console.WriteLine("su ciclo de estudio es :" + ciclo);

        }
    }
}
