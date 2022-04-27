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

        private static int Summ()
        {
            int value1;
            int value2;
            val1:
                Console.WriteLine(@"Введите значение первого члена: ");
                if (!Int32.TryParse(Console.ReadLine(), out value1))
                    goto val1;
            val2:
                Console.WriteLine(@"Введите значение второго члена: ");
                if (!Int32.TryParse(Console.ReadLine(), out value2))
                    goto val2;
                return value1 + value2;
        }

        private static int Dif()
        {
            int value1;
            int value2;
            val1:
                Console.WriteLine(@"Введите значение уменьшаемого: ");
                if (!Int32.TryParse(Console.ReadLine(), out value1))
                    goto val1;
            val2:
                Console.WriteLine(@"Введите значение вычитаемого: ");
                if (!Int32.TryParse(Console.ReadLine(), out value2))
                    goto val2;
                return value1 - value2;
        }

        private static int Mult()
        {
            int value1;
            int value2;
        val1:
                Console.WriteLine(@"Введите значение первого множителя: ");
                if (!Int32.TryParse(Console.ReadLine(), out value1))
                    goto val1;
            val2:
                Console.WriteLine(@"Введите значение второго множителя: ");
                if (!Int32.TryParse(Console.ReadLine(), out value2))
                    goto val2;
                return value1 * value2;
        }

        private static int Div()
        {
            int value1;
            int value2;
           val1:
                Console.WriteLine(@"Введите значение делимого: ");
                if (!Int32.TryParse(Console.ReadLine(), out value1))
                    goto val1;
            val2:
                Console.WriteLine(@"Введите значение делителя: ");
                if (!Int32.TryParse(Console.ReadLine(), out value2))
                    goto val2;
            if (value2 == 0)
            {
                Console.WriteLine(@"Делитель не может быть равен нулю");
                goto val2;
            }
                
            return value1 / value2;
        }

        private static double DivRem()
        {
            int value1;
            int value2;
            val1:
                Console.WriteLine(@"Введите значение делимого: ");
                if (!Int32.TryParse(Console.ReadLine(), out value1))
                    goto val1;
            val2:
                Console.WriteLine(@"Введите значение делителя: ");
                if (!Int32.TryParse(Console.ReadLine(), out value2))
                    goto val2;
            if (value2 == 0)
            {
                Console.WriteLine(@"Делитель не может быть равен нулю");
                goto val2;
            }

            return value1 % value2;
        }
    }
}
