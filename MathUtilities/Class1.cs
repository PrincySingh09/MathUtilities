using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilities
{
    public class MathUtility
    {
        public int Add(int a, int b)
        { return a + b; }
        public int Subtract(int a, int b)
        { return a - b; }
        public int Multiply(int a, int b)
        { return a * b; }
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException();
            }
            return a / b;
        }
        public bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}

