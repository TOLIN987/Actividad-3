using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    internal class Operation : Obteined_numbers
    {
        public Operation(double num1, double num2) : base(num1, num2)
        {
        }
        public override void Addition()
        {
            base.Addition(); Console.WriteLine(" {0} + {1} is {2}", num1, num2, (num1+num2));
        }
        public override void Multiplication()
        {
            base.Multiplication(); Console.WriteLine("{0} * {1} is {2}", num1,num2,(num1*num2));
        }
        public override void Substraction()
        {
            base.Substraction(); Console.WriteLine("{0} - {1} is {2}", num1, num2, (num1 - num2));
        }
        
    }
}
