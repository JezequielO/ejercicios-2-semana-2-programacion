using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_8_semana_2_programacion
{
    class Program
    {

    class Program
    {
        static void Main(string[] args)
        {
         int a=0,i,n;
         Console.WriteLine("Ingrese numero");
         n = Convert.ToInt32(Console.ReadLine());
         for(i=1;i<(n+1);i++){
         if(n%i==0){
             a++;
            }
         }
         if(a!=2){
              Console.WriteLine("No es Primo");
            }else{
                Console.WriteLine("Si es Primo");
         }
          Console.ReadLine();
        }
    }
}
}
