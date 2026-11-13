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

        public static void DifferentMethods()
        {
            // Написать метод Greet(string name, int age) ,
            // который выводит «Привет, {подставить имя}! Тебе {подставить возраст} лет.» Вызвать для трёх разных людей.

            /*
            Greet(17, "Stepa");
            Greet(25, "Sasha");
            Greet(9, "Misha");

            string returned_name = Greet_2(10, "Sveta");
            Console.WriteLine("Имя, которое мы вернули из метода: " + returned_name);
            string returned_name_2;
            returned_name_2 = Greet_2(20, "Anna");
            Console.WriteLine(Greet_2(30, "Victor"));
            */

            Console.WriteLine(SquareArea(100));
            int result;
            result = SquareArea(50);
            Console.WriteLine("Площадь квадрат: " + result);
            int number = 10;
            int sum = result + number;
        }

        public static int SquareArea(int a)
        {
            int area = a * a;
            return area;
        }





        public static void Greet(int age, string name)
        {
            Console.WriteLine($"Привет, {name} Тебе {age} лет");

        }
        public static string Greet_2(int age, string name)
        {
            Console.WriteLine($"Привет, {name} Тебе {age} лет");

            return name;

        }
    }
}
