using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar distancia(kilometros) entre 2 ciudades, velocidad media (k/h)
            //calcular y mostrar tiempo aproximado
            float distancia, velocidadMedia, tiempo;
            Console.WriteLine("Ingrese la distancia entre las 2 ciudades (Km): ");
            distancia = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad media del auto (k/h): ");
            velocidadMedia = float.Parse(Console.ReadLine());

            tiempo = distancia / velocidadMedia;

            Console.WriteLine("El tiempo aproximado es de " + tiempo.ToString("0.00") + " horas");
            //El ToString puedo usarlo para que no muestre todos los decimales
        }
    }
}
