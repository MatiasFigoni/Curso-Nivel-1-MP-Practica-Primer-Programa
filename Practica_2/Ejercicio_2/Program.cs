using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar numero y mostrar el valor elevado al cubo
            Console.WriteLine("Ingrese un numero: ");
            int num, result;
            num = int.Parse(Console.ReadLine());
            result = num * num * num; //tambien puedo usar el num para reemplazarlo
            Console.WriteLine("Su numero elevado al cubo es: " + result);
        }
    }
}
