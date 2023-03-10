using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    internal class Obteined_numbers
    {
        protected double num1;
        protected double num2;

        public Obteined_numbers(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public virtual void Addition()
        {
            Console.Write("The addition of");
        } 
        public virtual void Substraction()
        {
            Console.Write("The Substraction of ");
        }
        public virtual void Multiplication()
        {
            Console.Write("The Multiplication of ");
        }
    }
}
