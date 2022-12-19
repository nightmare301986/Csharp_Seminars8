/*Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 1 | 3 4
3 2 1 | 3 3
_ _ _ | 1 1
Результирующая матрица будет:
19 21
16 19*/
int Promt(String message) //Приглашение ко вводу
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m1 = Promt("Введите число строк в матрице1  ");
int n1 = Promt("Введите число столбцов в матрице1  ");
int m2 = Promt("Введите число строк в матрице2  ");
int n2 = Promt("Введите число столбцов в матрице2  ");

int[,] InputMatrix1(int m1, int n1) //Заполнение матрицы1 с учетом размера (количества строк, столбцов)
{
    int[,] matr1 = new int[m1, n1];
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n1; j++)
        {
            matr1[i, j] = new Random().Next(0, 10);
        }
    }
    return matr1;
}
int[,] InputMatrix2(int m2, int n2) //Заполнение матрицы2 с учетом размера (количества строк, столбцов)
{
    int[,] matr2 = new int[m2, n2];
    for (int i = 0; i < m2; i++)
    {
        for (int j = 0; j < n2; j++)
        {
            matr2[i, j] = new Random().Next(0, 10);
        }
    }
    return matr2;
}

int[,] matr1 = InputMatrix1(m1, n1);
int[,] matr2 = InputMatrix2(m2, n2);

void PrintMatrix1(int[,] matr1)//Вывод матрицы1 на экран
{
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n1; j++)
        {
            Console.Write($"{matr1[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void PrintMatrix2(int[,] matr2)//Вывод матрицы2 на экран
{
    for (int i = 0; i < m2; i++)
    {
        for (int j = 0; j < n2; j++)
        {
            Console.Write($"{matr2[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] MultiMatrix(int[,] a, int[,] b)//Перемножение матриц
{
    //if (n1 != m2) {System.Console.WriteLine("!Невозможно перемножить матрицы!");}
    int[,] r = new int[matr1.GetLength(0), matr2.GetLength(1)];
    if (a.GetLength(1) != b.GetLength(0)) return r;
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr2.GetLength(0); k++)
            {
                r[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return r;
}
void PrintMultiMatrix(int[,] a)//Ввод перемноженных матриц
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0} ", a[i, j]);
        }
        Console.WriteLine();
    }
}

PrintMatrix1(matr1);
Console.WriteLine();
PrintMatrix2(matr2);
Console.WriteLine();
if (n1 != m2) { System.Console.WriteLine("Перемножить матрицы невозможно"); }
int[,] mult = MultiMatrix(matr1, matr2);
PrintMultiMatrix(mult);
