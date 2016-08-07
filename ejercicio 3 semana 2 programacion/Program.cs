using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3_semana_2_programacion
{
    class Program 
    {
        static void Main(string[] args)
        {
            var texto = Console.ReadLine();
            var letras = texto.ToArray();
            var cantidad = letras.Count();

            for (int i = 0; i < cantidad; i++)
            { 
                Console.WriteLine (letras [i]);
                if (i < cantidad-1)
                    Console.WriteLine (letras [i] + letras [i + 1]);
                if (i < cantidad-2)
                    Console.WriteLine (letras [i] + letras [i + 1] + (i + 2));
                Console.ReadLine();

            }
        }
    }
}
