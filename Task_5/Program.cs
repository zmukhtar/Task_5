using static System.Math;
// See https://aka.ms/new-console-template for more information
int getNumberOne, getNumberTwo;
double getDoubleOne;
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
        getNumberOne = GetOneIntKeyboard();
        if (getNumberOne <= 9)
        {
            break;  
        }
        Console.WriteLine("Некорректное число.");
    }
    while (true) ;
    
    switch (getNumberOne)
    {
        case (1):
            Console.WriteLine("Task_4_1. Вывести все квадраты натуральных чисел, не превосходящие данного числа N.");
            Console.WriteLine("Введите предел.");
            getNumberOne = GetOneIntKeyboard();
            GetSquareNumber(getNumberOne); 
            break;
        case (2):
            Console.WriteLine("Task_4_2. Вывести на экран кубы чисел от A до B, которые вводит пользователь.");
            Console.WriteLine("A: ");
            getNumberOne = GetOneIntKeyboard();
            Console.WriteLine("B: ");
            getNumberTwo = GetOneIntKeyboard();
            GetNumberCubed(getNumberOne, getNumberTwo);
            break;
        case (3):
            Console.WriteLine("Task_4_3 Написать программу на языке C#, которая возводит число в целочисленную степень. Число и степень вводятся с клавиатуры.");
            Console.Write("Число: ");
            getDoubleOne = GetOneDoubleKeyboard();
            Console.Write("Степень: ");
            getNumberOne = GetOneIntKeyboard();
            GetExponentiation(getDoubleOne,getNumberOne);
            break;
        case (4):
            Console.WriteLine("Используя цикл написать программу, которая выводит на экран таблицу значений функции " +
                              "y = 5 - x2/2 на отрезке [-5; 5] с шагом 0.5.");
            GetTableFunction();
            break;
        case (5):
            Console.Write("Введите число от 0 до 255: ");
            GetFactorial(GetOneByteKeyboard());
            break;
        case (6):
            Console.WriteLine("Вывести на экран ряд чисел Фибоначчи, состоящий из N элементов. Значение N вводится с клавиатуры.");
            GetNumbersFibonachi(GetOneIntKeyboard());
            break;
        case (7):
            GetSeracuz();
            break;
        case (8):
            Console.WriteLine("Извлечение цифр числа.");
            Console.Write("Введите целое число: ");
            GetNumbers(GetOneIntKeyboard());
            break;
        case (9):
            Environment.Exit(0);
            break;
    }
    StartProgramm();
}

// 1
void GetSquareNumber(int i)
{
    int  xNumber = 1, yNumber = 1;
      while (yNumber < i)
      {
            Console.Write($"{yNumber} ");
            xNumber += 1;
            yNumber = (xNumber * xNumber);
      }
    Console.WriteLine();
}

// 2
void GetNumberCubed(int aNumber,int bNumber)
{
    for (int i = aNumber; i <= bNumber; i++)
     Console.WriteLine($"{i} в кубе = {i*i*i}");
}

// 3
void GetExponentiation(double num, int deg)
{
    double  res;
    res = 1;
    for (int i = 1; i <= Abs(deg); i++)
    res = res * num;
    if (deg < 0)
    res = 1 / res;
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
void GetFactorial(int n)
{  
    Int64 factorial;
    factorial = 1;
    for (int i = 2; i <= n; i++)
        factorial = factorial * i;
    Console.Write($"n != {factorial}" );
}

// 6
void GetNumbersFibonachi(int n)
{
    int a, b, c;
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
            n = (short)(n / 2);
            else
            n = (short)((3 * n + 1) / 2); 
            Console.Write($" |{n}|");
        }    
        Console.WriteLine();
    }
}

// 8
void GetNumbers(int n)
{
    n = Abs(n);
    while (n != 0)
    {
        Console.WriteLine(n % 10);
        n = n / 10;
    }
} 

static int GetOneIntKeyboard()
{
    do
    {
        string oneNumberRead = Console.ReadLine();
        bool result = Int32.TryParse(oneNumberRead, out int i);
        if (result)
        {
            return i;
            break;
        }
        Console.WriteLine("Некорректное число.");
    } while (true);
}

static double GetOneDoubleKeyboard()
{
    do
    { 
        
        string numString = Console.ReadLine();
        bool result = double.TryParse(numString, out double i);
        if (result)
        {
            return i;
            break;
        }
        Console.WriteLine("Некорректное число.");
    } while (true);
}

static byte GetOneByteKeyboard()
{
    do
    { 
        
        string nString = Console.ReadLine();
        bool result = byte.TryParse(nString, out byte i);
        if (result)
        {
            return i;
            break;
        }
        Console.WriteLine("Некорректное число.");
    } while (true);
    
}