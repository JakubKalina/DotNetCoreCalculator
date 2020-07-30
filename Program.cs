using System;

namespace Calculator
{
    class Calculator
    {
        public static double PerformOperation(double num1, double num2, string operation)
        {
            double result = double.NaN;

            switch(operation)
            {
                case "add":
                    result = num1 + num2;
                    break;
                case "sub":
                    result = num1 - num2;
                    break;
                case "mul":
                    result = num1 * num2;
                    break;
                case "div":
                    if(num2 != 0)
                       result = num1 / num2;
                    break;
                default:
                    break;
            }
            
            return result;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            while(!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.WriteLine("Prosze podać pierszą liczbę: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                
                while(!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.WriteLine("Podana wartość jest nieprawidłowa, wprowadź ponownie: ");
                    numInput1 = Console.ReadLine();
                }




                Console.WriteLine("Prosze podać drugą liczbę: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;

                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.WriteLine("Podana wartość jest nieprawidłowa, wprowadź ponownie: ");
                    numInput2 = Console.ReadLine();
                }


                Console.WriteLine("Wybierz działanie");
                Console.WriteLine("\tadd - dodawanie");
                Console.WriteLine("\tsub - odejmowanie");
                Console.WriteLine("\tmul - mnożenie");
                Console.WriteLine("\tdiv - dzielenie");

                string operation = Console.ReadLine();

                try
                {
                    result = Calculator.PerformOperation(cleanNum1, cleanNum2, operation);
                    if(double.IsNaN(result))
                    {
                        Console.WriteLine("Wystąpił błąd podczas obliczeń");
                    }
                    else
                    {
                        Console.WriteLine("Wynik: {0}", result);
                    }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wystąpił błąd. \n - " + e.Message);
                }

                Console.WriteLine("Aby wyjśc wybierz 'esc' ");
                if (Console.ReadLine() == "esc") endApp = true;


            }


        }
    }
}
