namespace _1проект.Lessons
{
    // Урок 1. Переменные, типы данных, ввод и вывод в консоль
    internal static class Lesson1
    {
        // Знакомство: программа спрашивает имя пользователя и здоровается с ним
        public static void GreetUser()
        {
            Console.Write("Как тебя зовут? ");
            string newName = Console.ReadLine();
            Console.WriteLine("имя новое " + newName);
            Console.WriteLine("Привет, " + newName + "! Рад знакомству.");
        }

        // Пользователь вводит два целых числа, программа выводит их сумму и сумму, умноженную на 2.
        // Заодно разбираем разницу между Console.Write и Console.WriteLine
        public static void SumOfTwoNumbers()
        {
            Console.Write("Введи первое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введи второе число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 + number2;
            Console.Write("Результат: " + result);

            int result2 = result * 2;
            Console.Write("Результат 2 " + result2);
            Console.WriteLine("Результат 2 " + result2);
            Console.Write("Результат 2 " + result2);
        }

        // Деление дробных чисел (тип float): 5 / 3
        public static void FloatDivision()
        {
            float number3 = 5f;
            float number4 = 3f;
            float result3 = number3 / number4;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(result3);
        }
    }
}
