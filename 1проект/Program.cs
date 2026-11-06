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



static int SquareArea(int a)
{
    int area = a * a;
    return area;
}





static void Greet(int age, string name)
{
    Console.WriteLine($"Привет, {name} Тебе {age} лет");

}
static string Greet_2(int age, string name)
{
    Console.WriteLine($"Привет, {name} Тебе {age} лет");

    return name;

}