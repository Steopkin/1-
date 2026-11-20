using System.Data;
using System.Text;

{
    Console.OutputEncoding = Encoding.UTF8;
}

// Метод-исполнитель - выполняет ту логику, что прописана внутри.
// В данном случае печатает строки в консоль
// Без параметров; ничего не возвращает
/*
PrintMenu();
RocketCountdown();

SuDrawHealthBarm(10, 10);

Greet(15, "Anna");
Sum(10, 20);

ShowLoading();


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


// Задание 1 «Экран загрузки»: Создай метод ShowLoading(), который имитирует загрузку игры.
// Он должен вывести текст Загрузка и затем в цикле 3 раза дописать точку с небольшой паузой (System.Threading.Thread.Sleep(500);).
// В конце вывести Готово!.


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

// Метод "Исполнитель-приёмник" - принимает данные(параметры) извне
// и выполняет ту логику, что прописана внутри, используя принятые данные.
// Принимает на вход имя пользователя (string name) и возраст(int age) и здоровается лично с ним
// С двумя параметром; ничего не возвращает


static void Greet(int age, string name)
{
    Console.WriteLine($"Привет, {name} Тебе {age} лет");

}

static void Sum(int a, int b)
{
    int sum = a + b;
    Console.WriteLine($"Sum: {sum}");
}



// Задание 2 «Индикатор здоровья»: Создай метод DrawHealthBar(int currentHp, int maxHp).
// Он должен нарисовать в консоли полоску жизни персонажа из символов '♥'
// Например, если currentHp = 3, а maxHp = 5, метод выведет: [ ♥ ♥ ♥ · · ].


 
static void SuDrawHealthBarm(int currentHp, int maxHp)
{
    Console.Write('[');
    for(int b=0; b < currentHp; b++)
    {
        Console.Write('♥');
    }
    for (int x = 0; x < maxHp - currentHp; x++)
    {
        Console.Write('·');
    }
    Console.Write(']');
}

// Метод "Информатор" - сообщает и передаёт данные указанного возвращаемого типа (в данном случае - string)
// Если вызвать этот метод, то он сообщает текущую версию программы
// Без параметров; возвращает данные типа string

string pass = GetProgramVersion();

static string GetProgramVersion()
{
    Console.WriteLine("fsfsfs");
    Console.WriteLine("fsfsfs");
    Console.WriteLine("fsfsfs");
    Console.WriteLine("fsfsfs");

    string password = "2234";
    return password;
}

int b;
b = GetUserId();
//Console.WriteLine(b);

// Без параметров; возвращает данные типа int
static int GetUserId()
{
    for (int a = 1; a < 5; a++)
    {

    }

    int userId = 123;
    int sum = userId + 20;
    return sum;
}
*/


// Задание 3 «Генератор пароля из 4 цифр»: Создай метод GeneratePinCode(),
// который генерирует 4 случайные цифры,
// склеивает их в одну строку (например, "0492") и возвращает эту строку наружу.
// Результат(пароль) вывести в консоль.
/*
string c;
c = GeneratePinCode();
Console.WriteLine(c);
Console.WriteLine(GeneratePinCode());*/

static string GeneratePinCode()
{
    string password = "";
    Random rand = new Random();
    for (int a =1; a < 5; a++)
    {
                  
        int randomNumber = rand.Next(0, 10); 
        Console.WriteLine(randomNumber);
        password = password + randomNumber;
       
    }
    return password;

}

// Метод "Универсал" - и принимает данные(параметры) и передаёт данные указанного возвращаемого типа 
// Принимает два числа, складывает их и возвращает результат в виде числа
int n = 10;

int resilt = CalculateSomething3(n, 20);
static int CalculateSomething3(int a, int b)
{
    int result = a + b;
    return result;
}

static int CountAllUsers(string[] users)
{
    int count = 0;
    foreach (string user in users)
    {
        count++;
    }
    return count;
}

bool isEven = true;
bool isActive = false;
bool isCritical = false;
int damage = 20;
CalculateDamage(damage, false);


// Задание 4 «Критический урон»: Создайте метод CalculateDamage(int baseDamage, bool isCritical).
// Если параметр isCritical равен true, метод возвращает удвоенный урон.
// Если false — возвращает обычный базовый урон.
// Нужно вывести результат(урон) наружу

static int CalculateDamage( int baseDamage[],bool isCritical)
{
    if

}