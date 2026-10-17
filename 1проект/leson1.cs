using System;
using System.Collections.Generic;
using System.Text;

namespace _1проект
{
    internal class leson1
    {
        public void Execute()
        {
            string name = "Rodion";
            float code = 13.5f;



            //Console.Write("Как тебя зовут?");
            //string new_name = Console.ReadLine();
            //Console.WriteLine("имя новое " + new_name);
            //Console.WriteLine("Привет, " + new_name + "! Рад знакомству.");

            // Задача "Анкета специального агента": Написать программу, которая спрашивает у пользователя его имя, его кодовое имя (псевдоним) и возраст.
            // В конце программа должна вывести одну красивую строчку о данных пользователя(имя, псевдоним, возраст)

            /*
            Console.Write("Ваше имя?");
            String name_1 = Console.ReadLine();
            Console.Write("Ваше кодовое имя ?");
            String name_2 = Console.ReadLine();
            Console.Write("Ваш возраст? ");
            String age_1 = Console.ReadLine();
            Console.WriteLine("Ваше имя = " + name_1 + ", Ваше кодовое имя = " + name_2 + ", Ваш возраст = " + age_1);
            */
            
            Console.Write("Введи первое число: ");
            int number_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введи второе число: ");
            int number_2 = Convert.ToInt32(Console.ReadLine());
            int result = number_1 + number_2;
            Console.Write("Результат: " + result);
            int result_2 = result * 2;
            Console.Write("Результат 2 " + result_2);
            Console.WriteLine("Результат 2 " + result_2);
            Console.Write("Результат 2 " + result_2);

            float number_3 = 5f;
            float number_4 = 3f;
            float result_3 = number_3 / number_4;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(result_3);

        }
    }
}
