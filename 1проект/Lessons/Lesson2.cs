namespace _1проект.Lessons
{
    // Урок 2. Условия if / else и операторы сравнения
    //
    //   > и <      больше / меньше
    //   >= и <=    больше или равно / меньше или равно
    //   ==         сравнение на равенство
    //   !=         не равно (восклицательный знак в программировании часто означает «НЕ»)
    //   &&         логическое И
    //   ||         логическое ИЛИ
    internal static class Lesson2
    {
        // Пример: пользователь вводит возраст, программа решает, пускать ли его на фильм 12+
        public static void MovieAgeCheck()
        {
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
        }

        // Задача 1: программа просит ввести секретный пароль.
        // Если пользователь вводит правильный пароль (например, 1234), программа пишет «Доступ открыт!».
        // Если вводит что-то другое — «Ошибка! Вызвана охрана!»
        public static void CheckPassword()
        {
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
        }

        // Задача 2: пользователь вводит свою оценку (число от 1 до 10), программа отвечает текстом:
        // от 9 до 10 — «Отлично! Ты супер!»
        // от 7 до 8  — «Хорошо, но можно лучше»
        // от 4 до 6  — «Надо поднажать»
        // от 2 до 3  — «Вызываем родителей»
        public static void GradeToText()
        {
            Console.Write("оценку - ");
            int mark = Convert.ToInt32(Console.ReadLine());
            if ((mark >= 9) && (mark <= 10))
            {
                Console.WriteLine("Отлично! Ты супер!");
            }
            else if ((mark >= 7) && (mark <= 8))
            {
                Console.WriteLine("Хорошо, но можно лучше");
            }
            else if ((mark >= 4) && (mark <= 6))
            {
                Console.WriteLine("Надо поднажать");
            }
            else if ((mark >= 2) && (mark <= 3))
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
