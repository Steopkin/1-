using System;
using System.Collections.Generic;
using System.Text;

namespace _1проект
{
    internal class lesson3
    {
        // Задание: У монстра есть 100 единиц здоровья.
        // Напиши программу, которая в цикле атакует монстра случайным уроном от 10 до 25 единиц за каждый удар.
        // Программа должна выводить на каждом шаге: "Вы нанесли Х урона. У монстра осталось Y здоровья".
        // Цикл должен остановиться, как только здоровье монстра станет 0 или меньше. В конце выведи: "Монстр побежден!".
        public void ExecuteGameHitEnemy()
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
                else Console.WriteLine($"босс убит {health} ");
            }
        }

        // Задание: Игра «Угадай число». Компьютер загадывает случайное число от 1 до 50 (используй Random).
        // Пользователь пытается его угадать в цикле while.
        // Если пользователь ввел число больше загаданного, программа пишет: "Слишком много! Попробуй еще раз:".
        // Если меньше, программа пишет: "Слишком мало! Попробуй еще раз:".
        // Игра продолжается, пока число не будет угадано. В конце программа пишет: "Ура! Ты победил!".
        public void Executenumberguesser()
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
                else if (randomNumber == number)
                {
                    Console.WriteLine("Ура! Ты победил!");
                }
                

            }


        }


        public void Execute_Task_With_Energy()
        {
            int energy = 5;

            while (energy > 0)

            {
                if (energy >= 10)
                {
                    break;
                }
                Console.WriteLine("Я программирую! Запас энергии: " + energy);
                energy++; // декремент
                          // energy = energy - 1;
                          // energy -= 1;
            }
            Random rand = new Random(); // Создаем генератор случайных чисел
            int randomNumber = rand.Next(1, 11); // Генерирует число ОТ 1 до 10 (11 не включается!)
            Console.WriteLine(randomNumber);


            
        }

        public void Task_With_if_and_switch()
        {
           int button = 2;

           if (button == 1)
           {
               Console.WriteLine("Включён канал СТС");
           }
           else if (button== 2)
           {
               Console.WriteLine("выключить телевизор");
           }
           else if (button == 2)
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
                   Console.WriteLine("неврная кнопка");
                   break;

           }
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
