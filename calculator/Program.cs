using System;
using calculator.Classes;



namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarations of basics functions
            var firstNum = 0;
            var secondNum = 0;
            var operation = ""; 
            var sum = 0;
            var calculator = new calculatorOperations();

            Console.WriteLine("Type two number (integers) and type of mathematic operation (+ - * /)");


            /*We don't know what user will enter into code so we must catch exception
              in this case the most common exceptions are formatexception and overflow of memory
              so I will catch it and inform user about it if it's needed
            */
            try
            {
                firstNum = int.Parse(Console.ReadLine());
                secondNum = int.Parse(Console.ReadLine());
                operation = Console.ReadLine();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Błąd - nie podałeś prawidłowej wartości - spróbuj jeszcze raz");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Podana liczba jest zbyt duża, podaj inną liczbę");
            }

            if (operation == "+")
                sum = calculator.Add(firstNum, secondNum);
            else if(operation == "-")
                sum = calculator.Substract(firstNum, secondNum);
            else if (operation == "*")
                sum = calculator.Multiply(firstNum, secondNum);
            else
                sum = calculator.Divide(firstNum, secondNum);




            Console.WriteLine(sum);

        }
    }


}
