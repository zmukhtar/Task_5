using System.Text;
using static System.Math;
// See https://aka.ms/new-console-template for more information
int getNumberOne, getNumberTwo;
double getDoubleOne;
StartProgramm();
string answerTask;

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
            Print("Task_4_1. Вывести все квадраты натуральных чисел, не превосходящие данного числа N.");
            Print("Введите предел.");
            getNumberOne = GetOneIntKeyboard();
            Print(GetSquareNumber(getNumberOne));
            break;
        
        case (2):
            Print("Task_4_2. Вывести на экран кубы чисел от A до B, которые вводит пользователь.");
            Print("A: ");
            getNumberOne = GetOneIntKeyboard();
            Print("B: ");
            getNumberTwo = GetOneIntKeyboard();
            Print(GetNumberCubed(getNumberOne, getNumberTwo));
            
            break;
        case (3):
            Print("Task_4_3 Написать программу на языке C#, которая возводит число в целочисленную степень. Число и степень вводятся с клавиатуры.");
            Print("Число: ");
            getDoubleOne = GetOneDoubleKeyboard();
            Print("Степень: ");
            getNumberOne = GetOneIntKeyboard();
            Print(GetExponentiation(getDoubleOne,getNumberOne));
            break;
        case (4):
            Print("Используя цикл написать программу, которая выводит на экран таблицу значений функции " +
                              "y = 5 - x2/2 на отрезке [-5; 5] с шагом 0.5.");
            Print(" X      Y");
            Print(GetTableFunction());
            
            break;
        case (5):
            Print("Введите число от 0 до 255: ");
            Print(GetFactorial(GetOneByteKeyboard()));
            break;
        case (6):
            Print("Вывести на экран ряд чисел Фибоначчи, состоящий из N элементов. Значение N вводится с клавиатуры.");
            Print(GetNumbersFibonachi(GetOneIntKeyboard()));
            break;
        case (7):
            Print("Проверка гипотезы Сиракуз.");
            Print(GetSeracuz());
            break;
        case (8):
            Print("Извлечение цифр числа.");
            Print("Введите целое число: ");
            Print(GetNumbers(GetOneIntKeyboard()));
            break;
        case (9):
            Environment.Exit(0);
            break;
    }
    StartProgramm();
}

// 1
static string GetSquareNumber(int i)
{
    var sb = new StringBuilder();
    int  xNumber = 1, yNumber = 1;
      while (yNumber < i)
      {
            sb.Append($"{yNumber} ");
            xNumber += 1;
            yNumber = (xNumber * xNumber);
      }
    return sb.ToString();
}

// 2
static string GetNumberCubed(int aNumber,int bNumber)
{
    var sb = new StringBuilder();
    for (int i = aNumber; i <= bNumber; i++)
     sb.Append($"{i} в кубе = {i*i*i}");
    return sb.ToString();
}

// 3
static string GetExponentiation(double num, int deg)
{
    var sb = new StringBuilder();
    double  res;
    res = 1;
    for (int i = 1; i <= Abs(deg); i++)
    res = res * num;
    if (deg < 0)
    res = 1 / res;
    sb.Append(res.ToString("0.000"));
    return sb.ToString();
}

// 4
static string GetTableFunction()
{
    var sb = new StringBuilder();
    double x, y;
    x = -5;
    while (x <= 5)
    {
        y = 5 - x * x / 2;
        sb.Append($"{x.ToString("0.0")} | {y.ToString("0.00")}");
        x = x + 0.5;
    }
    return sb.ToString();
}

// 5
static string GetFactorial(int n)
{  
    var sb = new StringBuilder();
    Int64 factorial;
    factorial = 1;
    for (int i = 2; i <= n; i++)
        factorial = factorial * i;
    sb.Append($"n != {factorial}" );
    return sb.ToString();
}

// 6
static string  GetNumbersFibonachi(int n)
{
    var sb = new StringBuilder();
    int a, b, c;
     a = 0;
    sb.Append($"{a} ");
    b = 1;
    sb.Append($"{b} ");
    for (int i = 3; i <= n; i++)
    {
        sb.Append($"{a+b} ");
        c = b;
        b = a + b;
        a = c;
        
    }   
    return sb.ToString();
}

// 7
static string GetSeracuz()
{
    var sb = new StringBuilder();
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
            sb.Append($" |{n}|");
        }    
        sb.Append("n/");
    }
    return sb.ToString(); 
}

// 8
static string GetNumbers(int n)
{
    var sb = new StringBuilder();
    n = Abs(n);
    while (n != 0)
    {
        sb.Append(n % 10);
        n = n / 10;
    }

    return sb.ToString();
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

void Print(object answer)
{
    Console.WriteLine(answer);
}