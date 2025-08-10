using System;

namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;
            //Solicitar 2 numeros
            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            n2 = int.Parse(Console.ReadLine());
            //Calcular numero
            resultado = n1 + n2;
            //Emitir resultado
            Console.WriteLine("El resultado de la suma es: " + resultado);
        }
    }
}
