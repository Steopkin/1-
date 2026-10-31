using System;
using System.Collections.Generic;
using System.Text;

namespace _1проект
{
    internal class lesson4
    {
        public void ExecuteWhileCycles()
        {
           
            int i = 1;
            while (i <= 5)
            {
                Console.Write(i + " ");
                i++;
            }

            Console.WriteLine();

            
            for (int j = 1; j <= 5; j++)
            {
                Console.Write(j + " ");
            }

            for (int y = 10; y >= 1; y--)
            {
                Console.WriteLine(y);
                Thread.Sleep(1000);
            }


            Console.WriteLine("Ракета запущена!");

            // Задача 1. Вывести все чётные числа от 2 до 20.
            // способ 1
            for (int k = 2; k <= 20; k += 2)
            {
                Console.Write(k + " ");
            }
            // способ 2

            for (int l = 2; l <= 20; l += 2)
            {
                if (l % 2 == 0)
                {
                    Console.Write(l + " ");
                }
            }

            // Задача 2. Пользователь вводит N, программа выводит сумму 1 + 2 + … +N.
            Console.Write("введите число == ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int s = 1; s <= n; s++)
            {
                sum = sum + s;
            }
            Console.Write(sum + "-- сумма");

            // Задача 4: программа показывает меню, выполняет выбранное действие и снова
            // показывает меню, пока пользователь не выберет выход.
            int num = 0;
            do
            {
                Console.WriteLine("1 вариант - введите 1");
                Console.WriteLine("2 вариант - введите 2");
                Console.WriteLine("3 вариант - введите 3");
                Console.WriteLine("4 вариант - введите 4");
                Console.WriteLine("5 вариант - введите 5");
                num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    Console.WriteLine("1 вариант выбран -  вы все ещё в цикле");

                }
                if (num == 2)
                {
                    Console.WriteLine("2 вариант выбран -  вы все ещё в цикле");

                }
                if (num == 3)
                {
                    Console.WriteLine("3 вариант выбран -  вы все ещё в цикле");
                }
                if (num == 4)
                {
                    Console.WriteLine("4 вариант выбран -  вы все ещё в цикле");
                }
                if (num == 5)
                {
                    Console.WriteLine("5 вариант выбран -  вы покинули цикл");
                }
            } while (num != 5);

        }


    }
}