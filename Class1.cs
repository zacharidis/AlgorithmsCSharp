using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    internal class Class1
    {


        public static BigInteger Factorial(int n)
        {

            if (n < 1) return -1;

            if (n == 0 || n == 1) return 1;

            return n * Factorial(n - 1);
        }

        public static int Fibonacci(int n)
        {
            if (n<0) { return -1; }

            if (n == 0 || n == 1) { return n; }

            return Fibonacci(n - 1) + Fibonacci(n - 2);

            
        }

        public static int SumOfDigits(int n)

        {
            if (n < 0) { return 0; }
            if (n==0 ) { return 0; }
            return n%10 + SumOfDigits(n/10);
        }

        public static BigInteger RecursionPower(int baseInt, int expInt)
        {

            if(expInt <0 )
            {
                return -1; 
            }

            if(expInt==0)
            {
                return 1; 
            }

            return baseInt * RecursionPower(baseInt, expInt-1);
        }



    }
}
