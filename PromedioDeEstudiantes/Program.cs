using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioDeEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            double primeraNota;
            double segundaNota;
            double terceraNota;
            double definitivaDeNotas;
            Console.Write("Escriba las notas con coma(,) despues del entero");
            Console.WriteLine();
            Console.Write("Digite la nota del Primer Corte: ");
            primeraNota = Double.Parse(Console.ReadLine());
            Console.Write("Digite la nota del Segundo Corte: ");
            segundaNota= Double.Parse(Console.ReadLine());
            Console.Write("Digite la nota del Tercer Corte: ");
            terceraNota = Double.Parse(Console.ReadLine());
            definitivaDeNotas = ( (primeraNota + segundaNota + terceraNota) /3 );
            Console.WriteLine( );
            if (definitivaDeNotas >= 3)
            {
                Console.Write($"|||El estudiante gano ,Su nota definitiva es: {definitivaDeNotas}|||");
            }
            else
            {
                Console.Write($"|||El estudiante perdio,Su nota definitiva es: {definitivaDeNotas}|||");
            }
            Console.ReadKey();
        }
    }
}
