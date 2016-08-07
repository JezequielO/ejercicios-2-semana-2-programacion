using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5_semana_2_programacion
{
    class Program
    {

public class mayusculas
{

    public static void Main()
    {
        Console.WriteLine("Ingrese palabra:");
        string palabra = Console.ReadLine(); 

        Console.WriteLine("El texto es: {0}",
          palabra);
        
        Console.WriteLine("En mayúsculas: {0}",
          palabra.ToUpper());
      

                Console.ReadLine();
    }
}
    }
}
