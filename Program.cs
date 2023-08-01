/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
double[,] RandomArray()
{
    int m = 3;
    int n = 4;
    double[,] randomArray = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            randomArray[i,j] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 2);
        }
    }
    return randomArray;
}

void ShowArray(double[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write(newArray[i, j] + " ");
        }
    Console.WriteLine("");
    }
}
ShowArray(RandomArray());
*/


/*
Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

/*
void ShowArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write(newArray[i, j] + " ");
        }
    Console.WriteLine("");
    }
}

void FindValue(int[,] duArray, int userRows, int userColl)
{
    if (userRows > 0 && userRows <= duArray.GetLength(0) && 
        userColl > 0 && userColl <= duArray.GetLength(1))
        Console.Write("This is your value: " + duArray[userRows-1, userColl-1]);
    else 
        Console.Write($"Rows: {userRows} and Collumns: {userColl} - Wrong number");
}

int[,] duArray = {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}};
ShowArray(duArray);

Console.Write("Enter number of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of collumns: ");
int userColl = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

FindValue(duArray, userRows, userColl);
*/


/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


double[] AverageArith(int[,] newArray)
{
    double [] averArray = new double[4];
    double bag = 0;
    for (int i = 0; i < newArray.GetLength(1); i++)
    {
        for (int j = 0; j < newArray.GetLength(0); j++)
        {
            bag = bag + newArray[j, i];
        }
        averArray[i] = bag/3;
        bag = 0;
    }
    return averArray;
}

void ShowArray(double [] newArray)
{
    Console.WriteLine("Average ariphmetic: ");
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"{newArray[i]:f2} ");
        Console.WriteLine("");
    }
}


int [,] newArray = {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}};

double [] averArray = AverageArith(newArray);
ShowArray(averArray);





