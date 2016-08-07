using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_semana_2_programacion
{
    class Program
    {
        public class comparacion_de_palabras
        {
            public static void Main()
            {

                string frase;
                string frase2;

                Console.WriteLine("Escriba una palabra");
                frase = Console.ReadLine();

                Console.WriteLine("Escriba la segunda palabra");
                frase2 = Console.ReadLine();

                if (frase == frase2)
                    Console.WriteLine("ambas son iguales");


                if (frase.CompareTo(frase2) > 0)
                    Console.WriteLine("la frase de {0} es  mas corta  que  {1}", frase, frase2);
                else if (frase.CompareTo(frase2) < 0)
                    Console.WriteLine("la frase de {1} es  mas larga  que   {0}", frase2, frase);


                Console.ReadLine();
            }
        }

    }
}
