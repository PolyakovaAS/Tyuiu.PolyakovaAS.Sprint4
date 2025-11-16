using Tyuiu.PolyakovaAS.Sprint4.Task4.V20.Lib;

DataService ds = new DataService();


Console.WriteLine("Введите количество строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
Console.WriteLine("***************************************************************************");


for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"Введите элемент массива {i},{j}:");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine();
Console.WriteLine("Введённый массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
Console.WriteLine("***************************************************************************");

int[,] res = ds.Calculate(matrix);

Console.WriteLine("Массив без чётных элементов:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{res[i, j]} \t");
    }
    Console.WriteLine();
}
Console.ReadLine();
        