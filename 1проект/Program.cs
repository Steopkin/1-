using System.Text;

{
    Console.OutputEncoding = Encoding.UTF8;
}
/*
// Метод-исполнитель - выполняет ту логику, что прописана внутри.
// В данном случае печатает строки в консоль
// Без параметров; ничего не возвращает

PrintMenu();
RocketCountdown();
static void PrintMenu()
{
    Console.WriteLine("1 - Сложить");
    Console.WriteLine("2 - Умножить");
    Console.WriteLine("0 - Выход");
}

// Обратный отсчёт от 10 до 1 с паузой в секунду, затем «Ракета запущена!»
static void RocketCountdown()
{
    for (int y = 10; y >= 1; y--)
    {
        Console.WriteLine(y);
        Thread.Sleep(1000);
    }

    Console.WriteLine("Загрузка...");
}

static void Method1()
{

    for (int i=1; i<4; i++)
    {

    }
}
*/

// Задание 1 «Экран загрузки»: Создай метод ShowLoading(), который имитирует загрузку игры.
// Он должен вывести текст Загрузка и затем в цикле 3 раза дописать точку с небольшой паузой (System.Threading.Thread.Sleep(500);).
// В конце вывести Готово!.


ShowLoading();
static void ShowLoading()
{
    Console.Write("Загрузка");
    for(int t = 1;t < 4; t++)
    {
        Thread.Sleep(1000);
        Console.Write(".");
        
    }
    Console.WriteLine("Готово!");
}