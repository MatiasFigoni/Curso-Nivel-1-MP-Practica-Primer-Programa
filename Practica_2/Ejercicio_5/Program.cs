using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 3 notas y luego calcular el promedio final
            //Mostrar en pantalla el promedio
            float nota1, nota2, nota3, promedio;
            Console.WriteLine("Ingrese la primera nota: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota: ");
            nota3 = float.Parse(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("El promedio es: " + promedio.ToString("0.00"));
        }
    }
}
