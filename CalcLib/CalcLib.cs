﻿using System;

namespace CalcLib {
    public class RecursiveCalc {
               
        /// <summary>
        /// Returns the factorial for given input.  Initialise ans with 1
        /// </summary>
        /// <param name="input"></param>
        /// <param name="ans"></param>
        /// <returns></returns>
        public int FactorialRec(int input, int ans) {
            if (input < 0)
            {
                throw new StackOverflowException();
            }

            if (input == 0) {
                return ans;
            }

            ans = ans * input;
            return FactorialRec(input - 1, ans);
        }
        
        
        /// <summary>
        /// Checks if num is a Fibonacci Number
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool FibCheck(int num) {
            int ans = 0;
            int a = 1, b =1;
            
            while (ans < num) {
                ans = a + b;
                if (ans == num) {
                    return true;
                }

                a = b;
                b = ans;
            }
            return false;
        }
        
        /// <summary>
        /// Check if num is a prime number.  Initialise divisor with 2
        /// </summary>
        /// <param name="num"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public bool PrimeCheckRec(int num, int divisor) {
            if (divisor <= 0) {
                throw new System.DivideByZeroException();
            }

            if (num == divisor) {
                return true;
            }

            if (num > divisor) {
                return num % divisor != 0 && PrimeCheckRec(num, divisor + 1);
            }

            return false;
        }
        
        /// <summary>
        /// Returns the nth Fibonacci number
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="numFibs"></param>
        /// <returns></returns>
        public int FibonacciRec(int num1, int num2, int numFibs) {
            if(numFibs == 1 || numFibs == 2)
                return 1;
            if(numFibs == 0)
                return 0;
            
            if (numFibs > 2) {
                numFibs--;
                return FibonacciRec(num2, num2 + num1, numFibs);
            }   
            return num2;
        }
    }
}
