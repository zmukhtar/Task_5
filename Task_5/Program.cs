using static System.Math;
// See https://aka.ms/new-console-template for more information
int numberTask;
StartProgramm();

void StartProgramm()
{

    Console.WriteLine("Введите номер задания и нажмите Enter.");
    Console.WriteLine("1   Вывести все квадраты натуральных чисел, не превосходящие данного числа N.");
    Console.WriteLine("2   Вывести на экран кубы чисел от A до B, которые вводит пользователь.");
    Console.WriteLine(
        "3   Написать программу на языке C#, которая возводит число в целочисленную степень. Число и степень вводятся с клавиатуры.");
    Console.WriteLine("4   Используя цикл написать программу, которая выводит на экран таблицу значений функции " +
                      "y = 5 - x2/2 на отрезке [-5; 5] с шагом 0.5.");
    Console.WriteLine("5   Поиск факториала.");
    Console.WriteLine(
        "6   Вывести на экран ряд чисел Фибоначчи, состоящий из N элементов. Значение N вводится с клавиатуры.");
    Console.WriteLine("7   Проверка гипотезы Сиракуз.");
    Console.WriteLine("8   Извлечение цифр числа.");
    Console.WriteLine("9   Выход из программы.");
    do
    {
        Console.WriteLine("Введите номер задания от 1 до 8 и нажмите Enter.");
        string nunberTaskString = Console.ReadLine();
        bool result = Int32.TryParse(nunberTaskString, out int i);
        if ((result == true) && (i <= 9))
        {
            numberTask = i;
            break;
        }

        Console.WriteLine("Некорректное число.");
    } while (true);




    switch (numberTask)
    {
        case (1):
            GetSquareNumber();
            break;
        case (2):
            GetNumberCubed();
            break;
        case (3):
            GetExponentiation();
            break;
        case (4):
            GetTableFunction();
            break;
        case (5):
            GetFactorial();
            break;
        case (6):
            GetNumbersFibonachi();
            break;
        case (7):
            GetSeracuz();
            break;
        case (8):
            GetNumbers();
            break;
        case (9):
            Environment.Exit(0);
            break;
    }
    StartProgramm();

}

// 1
void GetSquareNumber()
{
    Console.WriteLine("Task_4_1. Вывести все квадраты натуральных чисел, не превосходящие данного числа N.");
//Например, если N = 50, то на экран должен быть выведен ряд 1 4 9 16 25 36 49.

    string nNumberRead = "";
    int nNumber, xNumber, yNumber;

    do
    { 
        Console.WriteLine("Введите предел:");
        nNumberRead = Console.ReadLine();
        bool result = Int32.TryParse(nNumberRead, out int i);
        if (result)
        {
            nNumber = i;
            xNumber = 1;
            yNumber = 1;

            while (yNumber < nNumber)
            {
                Console.Write($"{yNumber} ");
                xNumber += 1;
                yNumber = (xNumber*xNumber);
            }

            break;
        
        }
        Console.WriteLine("Некорректное число.");
    } while (true);
    
}

// 2
void GetNumberCubed()
{
    Console.WriteLine("Task_4_2. Вывести на экран кубы чисел от A до B, которые вводит пользователь.");

// A: 2
// B: 10
// 2 в кубе = 8
// 3 в кубе = 27
// 4 в кубе = 64
// 5 в кубе = 125
// 6 в кубе = 216
// 7 в кубе = 343
// 8 в кубе = 512
// 9 в кубе = 729
// 10 в кубе = 1000

    string aNumberRead = "";
    string bNumberRead = "";
    int aNumber, bNumber;

    do
    { 
        Console.Write("A: ");
        aNumberRead = Console.ReadLine();
        bool result = Int32.TryParse(aNumberRead, out int i);
        if (result)
        {
            aNumber = i;
            break;
        }
        Console.WriteLine("Некорректное число.");
    } while (true);

    do
    { 
        Console.Write("B: ");
        bNumberRead = Console.ReadLine();
        bool result = Int32.TryParse(bNumberRead, out int i);
        if (result)
        {
            bNumber = i;
            break;
        }
        Console.WriteLine("Некорректное число.");
    } while (true);

    for (int i = aNumber; i <= bNumber; i++)
    {
        Console.WriteLine($"{i} в кубе = {i*i*i}");
    }
 
}

// 3
void GetExponentiation()
{
    int deg;
    double num, res;


    Console.WriteLine("Task_4_3 Написать программу на языке C#, которая возводит число в целочисленную степень. Число и степень вводятся с клавиатуры.");

    do
    { 
        Console.Write("Число: ");
        string numString = Console.ReadLine();
        bool result = double.TryParse(numString, out double i);
        if (result)
        {
            num = i;
            break;
        }
        Console.WriteLine("Некорректное число.");
    } while (true);

    do
    { 
        Console.Write("Степень: ");
        string degString = Console.ReadLine();
        bool result = Int32.TryParse(degString, out int i);
        if (result)
        {
            deg = i;
            break;
        }
        Console.WriteLine("Некорректное число.");
    } while (true);

    res = 1;

    for (int i = 1; i <= Abs(deg); i++)
    {
        res = res * num;
    
    
    }
    if (deg < 0)
    {
        res = 1 / res;
        
    }
    Console.WriteLine(res.ToString("0.000"));
   
}

// 4
void GetTableFunction()
{
    double x, y;

    Console.WriteLine("Используя цикл написать программу, которая выводит на экран таблицу значений функции " +
                      "y = 5 - x2/2 на отрезке [-5; 5] с шагом 0.5.");

    x = -5;
    Console.WriteLine(" X      Y");

    while (x <= 5)
    {
        y = 5 - x * x / 2;
        Console.WriteLine($"{x.ToString("0.0")} | {y.ToString("0.00")}");
        x = x + 0.5;
    }
   
}

// 5
void GetFactorial()
{
    string nString = ""; 
    Int64 factorial;
    byte n; 

    do
    { 
        Console.Write("Введите число от 0 до 255: ");
        nString = Console.ReadLine();
        bool result = byte.TryParse(nString, out byte i);
        if (result)
        {
            n = i;
            break;
        }
        Console.WriteLine("Некорректное число.");
    } while (true);

    factorial = 1;
    for (int i = 2; i <= n; i++)
    {
        factorial = factorial * i;
    
    
    }
    Console.Write($"n != {factorial}" );
   
}

// 6
void GetNumbersFibonachi()
{
    int a, b, c, n;
    Console.WriteLine("Вывести на экран ряд чисел Фибоначчи, состоящий из N элементов. Значение N вводится с клавиатуры.");


    do
    { 
        Console.Write("n = ");
        string nReadLine = Console.ReadLine();
        bool result = Int32.TryParse(nReadLine, out int i);
        if (result)
        {
            n = i;

            break;
        
        }
        Console.WriteLine("Некорректное число.");
    } while (true);

    a = 0;
    Console.Write($"{a} ");
    b = 1;
    Console.Write($"{b} ");

    for (int i = 3; i <= n; i++)
    {
        Console.Write($"{a+b} ");
        c = b;
        b = a + b;
        a = c;
    }   
}

// 7
void GetSeracuz()
{
    Console.WriteLine("Проверка гипотезы Сиракуз.");


    short n;

    for (short i = 20; i <= 30; i++)
    {
        n = i;
        while ((n<1)||(n>1))
        {
            if ((n%2) == 0)
            {
                n = (short)(n / 2);
            }
            else
            {
                n = (short)((3 * n + 1) / 2);
            }
            Console.Write($" |{n}|");
            
        }    
        Console.WriteLine();

    }
 
}

// 8
void GetNumbers()
{
    Console.WriteLine("Извлечение цифр числа.");

    Int64 n;
    do
    { 
        Console.Write("Введите целое число: ");
        string nString = Console.ReadLine();
        bool result = Int32.TryParse(nString, out int i);
        if (result)
        {
            n = i;
            break;
        }
        Console.WriteLine("Некорректное число.");
    } while (true);

    n = Abs(n);
    while (n != 0)
    {
        Console.WriteLine(n % 10);
        n = n / 10;
    }
    
} 