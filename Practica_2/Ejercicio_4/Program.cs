using System;
using System.Reflection;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular el total del sueldo mas la comision del 5% de su total facturado
            //sueldo_fijo = 15000
            float totalFacturado, comision,total;
            const float porcentajeComision = 0.05F;
            const float sueldo_fijo = 15000;
            Console.WriteLine("Ingrese el total facturado por el empleado: ");
            totalFacturado = float.Parse(Console.ReadLine());
            comision = totalFacturado * porcentajeComision; //Agregamos la F al lado del 0.05 para indicarle que es un Float y no un Double
            total = sueldo_fijo + comision;
            Console.WriteLine("El sueldo del empleado es: " + total + " pesos");
        }
    }
}
