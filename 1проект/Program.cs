using _1проект;
using System.Globalization;

// Задача 4: программа показывает меню, выполняет выбранное действие и снова
// показывает меню, пока пользователь не выберет выход.
int num=0;
do
{
    Console.WriteLine("1 вариант - введите 1");
    Console.WriteLine("2 вариант - введите 2");
    Console.WriteLine("3 вариант - введите 3");
    Console.WriteLine("4 вариант - введите 4");
    Console.WriteLine("5 вариант - введите 5");
    num = int.Parse(Console.ReadLine());
    if (num == 1)
    {
        Console.WriteLine("1 вариант выбран -  вы все ещё в цикле");

    }
    if (num == 2)
    {
        Console.WriteLine("2 вариант выбран -  вы все ещё в цикле");

    }
    if (num == 3)
    {
        Console.WriteLine("3 вариант выбран -  вы все ещё в цикле");
    }
    if (num == 4)
    {
        Console.WriteLine("4 вариант выбран -  вы все ещё в цикле");
    }
    if (num == 5)
    {
        Console.WriteLine("5 вариант выбран -  вы покинули цикл");
    }
} while (num != 5); 


/*Console.WriteLine("1 вариант - введите 1");
Console.WriteLine("2 вариант - введите 2");
Console.WriteLine("3 вариант - введите 3");
Console.WriteLine("4 вариант - введите 4");
Console.WriteLine("5 вариант - введите 5");
int num =int.Parse(Console.ReadLine());
while (num != 5) */



































/*
// Задача 2. Пользователь вводит N, программа выводит сумму 1 + 2 + … +N.
Console.Write("введите число == ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int s = 1; s <= n; s++)
{
    sum = sum + s;
}
Console.Write(sum + "-- сумма");

// Задача 3: пользователь вводит число, программа выводит для него таблицу
// умножения от 1 до 10
Console.Write("введите число == ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
for (int m = 1; m < 10; m++) 
{
    num1 = num * m;
    Console.WriteLine($"{num} * {m}  = {num1}");
}

int x = 4;

while (x < 5)
{
    Console.WriteLine("Это while");
    break;
}

do
{
    Console.WriteLine("Это do-while");
    break;
} while (x < 5);
*/
