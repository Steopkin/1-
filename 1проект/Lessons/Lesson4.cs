namespace _1проект.Lessons
{
    // Урок 4. Циклы for, while, do-while
    internal static class Lesson4
    {
        // Пример: вывод чисел от 1 до 5 двумя способами — циклом while и циклом for
        public static void CountToFive()
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
            Console.WriteLine();
        }

        // Обратный отсчёт от 10 до 1 с паузой в секунду, затем «Ракета запущена!»
        public static void RocketCountdown()
        {
            for (int y = 10; y >= 1; y--)
            {
                Console.WriteLine(y);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Ракета запущена!");
        }

        // Задача 1: вывести все чётные числа от 2 до 20 (два способа)
        public static void EvenNumbers()
        {
            // способ 1: шаг цикла равен 2
            for (int k = 2; k <= 20; k += 2)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();

            // способ 2: проверка остатка от деления на 2
            for (int l = 2; l <= 20; l++)
            {
                if (l % 2 == 0)
                {
                    Console.Write(l + " ");
                }
            }
            Console.WriteLine();
        }

        // Задача 2: пользователь вводит N, программа выводит сумму 1 + 2 + … + N
        public static void SumFromOneToN()
        {
            Console.Write("введите число == ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int s = 1; s <= n; s++)
            {
                sum = sum + s;
            }
            Console.WriteLine(sum + "-- сумма");
        }

        // Задача 3: пользователь вводит число, программа выводит для него таблицу умножения от 1 до 10
        public static void MultiplicationTable()
        {
            Console.Write("введите число == ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int m = 1; m <= 10; m++)
            {
                int result = num * m;
                Console.WriteLine($"{num} * {m}  = {result}");
            }
        }

        // Задача 4: программа показывает меню, выполняет выбранное действие и снова
        // показывает меню, пока пользователь не выберет выход
        public static void MenuLoop()
        {
            int num;
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

        // Разница между while и do-while: при одном и том же условии
        // while сначала проверяет условие, а do-while сначала выполняет тело хотя бы один раз
        public static void WhileVsDoWhile()
        {
            int x = 4;

            while (x < 5)
            {
                Console.WriteLine("Это while");
                break;
            }

            do
            {
                Console.WriteLine("Это do-while");
                break;
            } while (x < 5);
        }
    }
}
