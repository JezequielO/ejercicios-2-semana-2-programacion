﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1_semana_2_programacion
{
    class Program
    {

        public class triangulo
        {
            public static void Main()
            {

                int NUM, AUX, DEC, UNI, CEN;
                string linea;
                Console.WriteLine("INGRESE EL NÚMERO DE TRES CIFRAS : ");
                linea = Console.ReadLine();
                NUM = int.Parse(linea);
                CEN = NUM / 100;
                NUM = NUM % 100;
                DEC = NUM / 10;
                UNI = NUM % 10;
                AUX = (UNI * 100) + (DEC * 10) + CEN;
                Console.WriteLine("NÚMERO INVERTIDO ES: " + AUX);
                Console.WriteLine("Pulse una Tecla:"); Console.ReadLine();
            }
        }
    }
}

