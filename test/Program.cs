using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = FibonacciRec(0,1,0);

            System.Console.WriteLine(num);

            Console.WriteLine(FactorialRec(3, 1));
        }

        public static int FactorialRec(int input, int ans) {
            if (input == 0) {
                return ans;
            }

            ans = ans * input;
            return FactorialRec(input - 1, ans);
        }

        public static int FibonacciRec(int num1, int num2, int numFibs) {
            if(numFibs == 2 && num2 == 1)
                return 1;
            if(numFibs == 0 || (numFibs == 1 && num2 == 1))
                return 0;
            
            if (numFibs > 2) {
                numFibs--;
                return FibonacciRec(num2, num2 + num1, numFibs);
            }   
            return num2;
        }
    }
}
