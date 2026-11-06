// Написать метод Greet(string name, int age) ,
// который выводит «Привет, {подставить имя}! Тебе {подставить возраст} лет.» Вызвать для трёх разных людей.
Greet(17, "Stepa");
Greet(25, "Sasha");
Greet(9, "Misha");
static void Greet(int age, string name)
{
    Console.WriteLine( $"Привет, {name} Тебе {age} лет");
    
}