using System;

namespace PracticalWork3
{
    class Program
    {
        static void Main()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("=== МЕНЮ ===");
                Console.WriteLine("1. Сума та кількість парних чисел");
                Console.WriteLine("2. Таблиця множення");
                Console.WriteLine("3. Визначення типу трикутника");
                Console.WriteLine("0. Вихід");
                Console.Write("Вибір: ");

                string input = Console.ReadLine() ?? "";
                Console.WriteLine();

                if (input == "1")
                {
                    SumEvenNumbers();
                }
                else if (input == "2")
                {
                    MultiplicationTable();
                }
                else if (input == "3")
                {
                    CheckTriangle();
                }
                else if (input == "0")
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Некоректний вибір!");
                }

                Console.WriteLine();
            }
        }

        static void SumEvenNumbers()
        {
            Console.Write("Введіть N: ");
            int n = Convert.ToInt32(Console.ReadLine() ?? "0");

            int sum = 0;
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Число " + i + ": ");
                int num = Convert.ToInt32(Console.ReadLine() ?? "0");

                if (num % 2 == 0)
                {
                    sum = sum + num;
                    count = count + 1;
                }
            }

            if (count > 0)
            {
                double avg = (double)sum / count;
                Console.WriteLine("Сума парних: " + sum);
                Console.WriteLine("Кількість парних: " + count);
                Console.WriteLine("Середнє значення: " + avg);
            }
            else
            {
                Console.WriteLine("Парних чисел немає.");
            }
        }

        static void MultiplicationTable()
        {
            int n = 0;

            while (n == 0)
            {
                Console.Write("Введіть N: ");
                n = Convert.ToInt32(Console.ReadLine() ?? "0");

                if (n == 0)
                {
                    Console.WriteLine("Число не повинно бути 0! Введіть повторно.");
                }
            }

            for (int i = 1; i <= 10; i++)
            {
                int res = n * i;
                Console.WriteLine(n + " * " + i + " = " + res);
            }
        }

        static void CheckTriangle()
        {
            Console.Write("Введіть a: ");
            double a = Convert.ToDouble(Console.ReadLine() ?? "0");

            Console.Write("Введіть b: ");
            double b = Convert.ToDouble(Console.ReadLine() ?? "0");

            Console.Write("Введіть c: ");
            double c = Convert.ToDouble(Console.ReadLine() ?? "0");

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("Трикутник існує.");

                if ((a == b) && (b == c))
                {
                    Console.WriteLine("Тип: рівносторонній.");
                }
                else if ((a == b) || (a == c) || (b == c))
                {
                    Console.WriteLine("Тип: рівнобедрений.");
                }
                else
                {
                    Console.WriteLine("Тип: різносторонній.");
                }
            }
            else
            {
                Console.WriteLine("Трикутник не існує.");
            }
        }
    }
}