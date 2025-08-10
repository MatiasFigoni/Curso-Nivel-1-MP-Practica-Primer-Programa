using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipo de dato: int, float, char, bool
            int num_1, num_2;
            Console.WriteLine("Ingrese un numero: ");
            //Paso 1: pedir valores
            num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            num_2 = int.Parse(Console.ReadLine());
            //Pas 2: realziar calculo
            int resultado = num_1 + num_2;
            //Paso 3: emitir resultado
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
