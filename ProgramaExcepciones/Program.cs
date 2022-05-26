﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Indique un numero: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Indique otro numero: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                Console.ReadKey();
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            //DivideByZeroException
            //FormatException
        }
    }
}
