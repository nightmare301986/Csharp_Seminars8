/* Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая 
будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int Promt(String message) //Приглашение ко вводу
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Promt("Введите число строк в матрице  ");
int n = Promt("Введите число столбцов в матрице  ");

int[,] InputMatrix(int m, int n) //Заполнение матрицы с учетом размера (количества строк, столбцов)
{
    int[,] matr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
    return matr;
}

int[,] matr = InputMatrix(m, n);

void PrintMatrix(int[,] matr)//Вывод матрицы на экран
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}
int nomerstr  = -1;
int sum = 0;
int minsum = 1000;

int MinSummaRows(int[,] matr) //Нахождение минимального(по столбцам) и максимального(по строкам) значения в матрице и разницы между ними
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
        if (sum < minsum) { minsum = sum; nomerstr = i + 1; }

    }
    return nomerstr;
}

PrintMatrix(matr);
System.Console.WriteLine($"Строка {MinSummaRows(matr)} это строка наименьшей суммой элементов ");