using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Actividad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double num1= 0;
            double num2= 0;
            bool Validation = false;
            while (Validation == false )
            {
                Console.Write("Write the first number");
                Validation = double.TryParse(Console.ReadLine(), out num1);
                if (Validation == false){Console.WriteLine("Write a valid Number");}
                else{break;}
            }
            Validation = false;
            while( Validation == false )
            {
                Console.Write("Write the second number");
                Validation = double.TryParse(Console.ReadLine(), out num2);
                if (Validation == false){Console.WriteLine("Write a valid Number");}
                else{break;}              
            }
            
            Obteined_numbers numbers = new Operation(num1, num2);
            numbers.Addition();
            numbers.Multiplication();
            numbers.Substraction();
        }
    }
}
