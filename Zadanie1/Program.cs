/* Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
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

void SortMatrRow(int[,] matr, int r)//Сортировка строк матриц по убыванию
{
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = i + 1; j < matr.GetLength(1); j++)
            if (matr[r, i] < matr[r, j])
            {
                int tmp = matr[r, i];
                matr[r, i] = matr[r, j];
                matr[r, j] = tmp;
            }
    }
}
PrintMatrix(matr);
Console.WriteLine();

void PrintMatrix2(int[,] matr)//Вывод отсортированной матрицы по элементам в строках на экран
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        SortMatrRow(matr, i);
    }

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j]}\t");
        Console.WriteLine();
    }
}
PrintMatrix2(matr);