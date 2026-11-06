namespace _1проект.Lessons
{
    // Урок 3. Цикл while, break, случайные числа (Random), switch
    internal static class Lesson3
    {
        // Пример: цикл while с break — энергия растёт, пока не дойдёт до 10
        public static void EnergyWhileLoop()
        {
            int energy = 5;

            while (energy > 0)
            {
                if (energy >= 10)
                {
                    break;
                }
                Console.WriteLine("Я программирую! Запас энергии: " + energy);
                energy++; // инкремент (увеличение на 1)
                // energy = energy + 1;
                // energy += 1;
            }
        }

        // Пример: как получить случайное число с помощью Random
        public static void RandomNumberExample()
        {
            Random rand = new Random();          // Создаем генератор случайных чисел
            int randomNumber = rand.Next(1, 11); // Генерирует число ОТ 1 до 10 (11 не включается!)
            Console.WriteLine(randomNumber);
        }

        // Задание: у монстра есть 100 единиц здоровья.
        // Программа в цикле атакует монстра случайным уроном от 10 до 25 единиц за каждый удар.
        // На каждом шаге выводит: "Вы нанесли Х урона. У монстра осталось Y здоровья".
        // Цикл останавливается, как только здоровье монстра станет 0 или меньше.
        // В конце выводит: "Монстр побежден!"
        public static void HitMonster()
        {
            int health = 100;
            Random rand = new Random();
            Console.WriteLine("Нажимай любую клавишу, чтобы ударить монстра");
            while (health >= 1)
            {
                Console.ReadKey();
                int randomDamage = rand.Next(10, 26);
                health = health - randomDamage;
                Console.WriteLine($"Вы нанесли {randomDamage} урона");
                if (health >= 1)
                {
                    Console.WriteLine($"здоровье босса = {health} нужно добить");
                }
                else
                {
                    Console.WriteLine($"босс убит {health} ");
                }
            }
        }

        // Задание: игра «Угадай число». Компьютер загадывает случайное число от 1 до 50.
        // Пользователь пытается его угадать в цикле while.
        // Если введённое число больше загаданного — "Слишком много! Попробуй еще раз:".
        // Если меньше — "Слишком мало! Попробуй еще раз:".
        // Игра продолжается, пока число не угадано. В конце — "Ура! Ты победил!"
        public static void GuessNumber()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 51);
            int number = 0;
            while (randomNumber != number)
            {
                Console.Write("введите число =  ");
                number = Convert.ToInt32(Console.ReadLine());
                if (randomNumber > number)
                {
                    Console.WriteLine("Введите число побольше");
                }
                else if (randomNumber < number)
                {
                    Console.WriteLine("Введите число поменьше");
                }
                else
                {
                    Console.WriteLine("Ура! Ты победил!");
                }
            }
        }

        // Пульт от телевизора: одна и та же логика выбора кнопки через if/else и через switch
        public static void TvRemote()
        {
            int button = 2;

            if (button == 1)
            {
                Console.WriteLine("Включён канал СТС");
            }
            else if (button == 2)
            {
                Console.WriteLine("выключить телевизор");
            }
            else if (button == 3)
            {
                Console.WriteLine("Включён канал ОНТ");
            }

            switch (button)
            {
                case 1:
                    Console.WriteLine("Включён канал СТС");
                    break;
                case 2:
                    Console.WriteLine("выключить телевизор");
                    break;
                default:
                    Console.WriteLine("неверная кнопка");
                    break;
            }
        }

        // Пользователь вводит номер дня недели, программа через switch выводит его название
        // (6 и 7 — выходные: пример нескольких case для одного действия)
        public static void DayOfWeek()
        {
            Console.Write("введите день недели  ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("ponedelnik");
                    break;
                case 5:
                    Console.WriteLine("pyatniza");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("vixadnoy");
                    break;
                default:
                    Console.WriteLine("oshibka");
                    break;
            }
        }
    }
}
