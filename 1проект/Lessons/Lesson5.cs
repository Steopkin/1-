namespace _1проект.Lessons
{
    // Урок 5. Методы: параметры, повторное использование кода
    internal static class Lesson5
    {
        // Пример урока: приветствие, ввод двух чисел и вывод суммы,
        // красиво разделённые линиями с помощью методов
        public static void MethodsDemo()
        {
            PrintLine('-', 50);
            Console.WriteLine("   ДОБРО ПОЖАЛОВАТЬ");
            PrintLine('*', 50);

            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            PrintLine('=', 20);

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            PrintLine('&', 20);
            Console.WriteLine("Сумма: " + (a + b));
            PrintLine('#', 20);

            PrintMenu();
            PrintMenu();

            PrintClientInfo(5, "Родион", 567575);
            PrintClientInfo(55, "John", 9797);
        }

        // Метод с параметрами: печатает линию из символа symbol длиной length
        public static void PrintLine(char symbol, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

        // Метод с несколькими параметрами разных типов: выводит информацию о клиенте
        public static void PrintClientInfo(int id, string name, int phone)
        {
            Console.WriteLine("Id клиента: " + id);
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Телефон: " + phone);
        }

        // Метод без параметров: печатает фиксированную линию-разделитель
        public static void PrintSeparator()
        {
            Console.WriteLine("=====================");
        }

        // Метод без параметров: печатает меню калькулятора
        public static void PrintMenu()
        {
            Console.WriteLine("1 - Сложить");
            Console.WriteLine("2 - Умножить");
            Console.WriteLine("0 - Выход");
        }
    }
}
