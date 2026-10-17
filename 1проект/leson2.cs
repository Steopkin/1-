using System;
using System.Collections.Generic;
using System.Text;

namespace _1проект
{
    internal class leson2
    {
        public void Execute()
        {
            /*
                            > и < (больше / меньше)
                            >= и <= (больше или равно / меньше или равно)
                            == Сравнение на равенство
                            != не равно (восклицательный знак в программировании часто означает «НЕ»).
                            && логическое И
                            || логическое ИЛИ
            */
            /*
            Console.Write("Сколько тебе лет? ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge >= 12)
            { 
                Console.WriteLine("К сожалению, этот фильм только для тех, кто страше 12");
            }
            else
            {
                Console.WriteLine("Доступ на этот фильм разрешен. Добро пожаловать на сеанс!");
            }
            // Задача 1: Программа просит ввести секретный пароль.
            // Если пользователь вводит правильное слово (например, "1234"), программа пишет: «Доступ открыт!».
            // Если вводит что-то другое — «Ошибка! Вызвана охрана!».
            */
            Console.Write("введите пароль - ");
            int password = Convert.ToInt32(Console.ReadLine());
            if (password == 1234)
            {
                Console.WriteLine("Доступ открыт!");
            }

            else
            {

                Console.WriteLine("Ошибка!");
            }

            // Задача 2: Пользователь вводит свою оценку (число от 1 до 10)
            // Программа должна ответить текстом
            // Если от 9 до 10 - «Отлично! Ты супер!»
            // Если от 7 до 8 - «Хорошо, но можно лучше»
            // Если от 4 до 6 - «Надо поднажать»
            // Если от 2 до 3 - «Вызываем родителей»

            Console.Write("оценку - ");
            int mark = Convert.ToInt32(Console.ReadLine());
            if ((mark >= 9) && (mark <= 10))
            {
                Console.WriteLine("Отлично! Ты супер!");
            }
            else if
                ((mark >= 7) && (mark <= 8))
            {
                Console.WriteLine("Хорошо, но можно лучше");

            }
            else if
                ((mark >= 4) && (mark <= 6))
            {
                Console.WriteLine("Надо поднажать");
            }
            else if
                ((mark >= 2) && (mark <= 3))
            {
                Console.WriteLine("Вызываем родителей");
            }
            else
            {
                Console.WriteLine("неправильное число");
            }
        }
    }
}
