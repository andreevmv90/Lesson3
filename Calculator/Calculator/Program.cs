using System;
using System.Globalization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                start:
                    Console.WriteLine(@"Введите операцию: +, -, *, /, %");
                    var op = Console.ReadLine();
                    switch (op)
                    {
                        case @"+":
                            Console.WriteLine($"Результат : { Summ() } \n");
                            break;
                        case @"-":
                            Console.WriteLine($"Результат : { Dif() } \n");
                            break;
                        case @"*":
                            Console.WriteLine($"Результат : { Mult() } \n");
                            break;
                        case @"/":
                            Console.WriteLine($"Результат : { Div() } \n");
                            break;
                        case @"%":
                            Console.WriteLine($"Результат : { DivRem() } \n");
                            break;
                        default:
                            goto start;
                    }
            }

        }

        private static double Summ()
        {
            double value1;
            double value2;
            val1:
                Console.WriteLine(@"Введите значение первого члена: ");
                if (!double.TryParse(Console.ReadLine(), out value1))
                    goto val1;
            val2:
                Console.WriteLine(@"Введите значение второго члена: ");
                if (!double.TryParse(Console.ReadLine(), out value2))
                    goto val2;
                return value1 + value2;
        }

        private static double Dif()
        {
            double value1;
            double value2;
            val1:
                Console.WriteLine(@"Введите значение уменьшаемого: ");
                if (!double.TryParse(Console.ReadLine(), out value1))
                    goto val1;
            val2:
                Console.WriteLine(@"Введите значение вычитаемого: ");
                if (!double.TryParse(Console.ReadLine(), out value2))
                    goto val2;
                return value1 - value2;
        }

        private static double Mult()
        {
            double value1;
            double value2;
            val1:
                Console.WriteLine(@"Введите значение первого множителя: ");
                if (!double.TryParse(Console.ReadLine(), out value1))
                    goto val1;
            val2:
                Console.WriteLine(@"Введите значение второго множителя: ");
                if (!double.TryParse(Console.ReadLine(), out value2))
                    goto val2;
                return value1 * value2;
        }

        private static double Div()
        {
            double value1;
            double value2;
            val1:
                Console.WriteLine(@"Введите значение делимого: ");
                if (!double.TryParse(Console.ReadLine(), out value1))
                    goto val1;
            val2:
                Console.WriteLine(@"Введите значение делителя: ");
                if (!double.TryParse(Console.ReadLine(), out value2))
                    goto val2;
            if (value2 < 1e-5)
            {
                Console.WriteLine(@"Делитель не может быть равен нулю");
                goto val2;
            }
                
            return value1 / value2;
        }

        private static double DivRem()
        {
            double value1;
            double value2;
            val1:
                Console.WriteLine(@"Введите значение делимого: ");
                if (!double.TryParse(Console.ReadLine(), out value1))
                    goto val1;
            val2:
                Console.WriteLine(@"Введите значение делителя: ");
            if (!double.TryParse(Console.ReadLine(), out value2))
                goto val2;
            if (value2 < 1e-5)
            {
                Console.WriteLine(@"Делитель не может быть равен нулю");
                goto val2;
            }

            return value1 % value2;
        }
    }
}
