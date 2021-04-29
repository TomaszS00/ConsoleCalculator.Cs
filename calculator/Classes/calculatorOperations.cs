using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Classes
{
    class calculatorOperations
    {
        /// <summary>
        /// Function should add two numbers 
        /// </summary>
        /// <param name="first">It's first num to add</param>
        /// <param name="second">it's second num to add</param>
        /// <returns>Return result of two numbers (first+second)</returns>
        public int Add(int first, int second)
        {
            return first + second;
        }

        /// <summary>
        /// Function should substract two numbers 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>Result of first-second</returns>
        public int Substract(int first, int second)
        {
            return first - second;
        }


        /// <summary>
        /// Function multiply two numbers
        /// </summary>
        /// <param name="first">First number to multiply</param>
        /// <param name="second">Second number to multiply</param>
        /// <returns>Return first*second</returns>
        public int Multiply(int first, int second)
        {
            return first * second;
        }

        /// <summary>
        /// Funtion divide two numbers
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>Returns result of divide first/second</returns>
        public int Divide(int first, int second)
        {
            return first / second;
        }
    }
}
