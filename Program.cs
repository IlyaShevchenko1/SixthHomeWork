// Sixth home work.

// Task 41. Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел
// пользователь.

/*

int[] CreateAnArray(int m)
{
    int[] array = new int[m];

    for (int i = 0; i < m; i++)
    {
        Console.Write($"Input a {i + 1} number out of the {m} numbers of massive: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

int PositiveCheck(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }

    return count;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

Console.Write("Input a quantity of numbers: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateAnArray(m);
Console.Write("Your array is: ");
WriteArray(myArray);
int check = PositiveCheck(myArray);
Console.WriteLine($"Quantity of positive numbers are {check}");

*/

// Task 43. Напишите программу, которая найдет точку пересечения двух прямых, заданных
// уравнениями y = k1x + b1, y = k2x + b2; значения к1, к2, b1, b2 задаются пользователем.

/*

Console.Write("Input a K1 for the first line: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a B1 for the first line: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a K2 for the first line: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a B2 for the first line: ");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 && b1 == b2) Console.WriteLine("Lines are coincidental");
else if (k1 == k2 && b1 != b2) Console.WriteLine("Lines are parallel and have no point of intersection");
else 
{
    int x = (b2 - b1) / (k1 - k2);
    int y = k1 * x + b1;

    Console.WriteLine($"Coordinate of intersection point is: ({x}; {y})");
}

*/

// Additional task. Написать программу, преобразующую число из десятеричной системы счисления 
// в двоичную.

/*

string Convert10to2(int num)
{
    string temp = "";
    while (num != 0)
    {
        temp = temp + num % 2 + " ";
        num = num / 2;
    }
    
    string result = "";
    for (int i = 0; i < temp.Length; i++)
    {
        result = result + temp[temp.Length - 1 - i];
    }

    return result;
}

Console.Write("Input a DEC number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0) Console.Write("Your number in BIN is: 0");
else
{
    string solution = Convert10to2(number);
    Console.Write("Your number in BIN is: ");
    Console.WriteLine(solution);
}

*/